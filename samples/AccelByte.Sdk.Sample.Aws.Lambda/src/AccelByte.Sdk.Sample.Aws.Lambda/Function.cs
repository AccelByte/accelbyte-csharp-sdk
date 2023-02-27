using System.Net;
using System.Text.Json;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AccelByte.Sdk.Sample.Aws.Lambda;

public class Functions
{
    private AccelByteSDK _Sdk;

    private string _ActiveStatCode;

    /// <summary>
    /// Default constructor that Lambda will invoke.
    /// </summary>
    public Functions()
    {
        _Sdk = AccelByteSDK.Builder
            .UseDefaultConfigRepository()
            .UseDefaultTokenRepository()
            .UseDefaultHttpClient()
            .Build();

        string? userStatCode = Environment.GetEnvironmentVariable("AB_USER_STAT_CODE");
        if (userStatCode != null)
            _ActiveStatCode = userStatCode;
        else
            _ActiveStatCode = "default-stat-code";
    }

    public APIGatewayHttpApiV2ProxyResponse Handler(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        string httpRequest = request.RequestContext.Http.Method;
        switch (httpRequest)
        {
            case "POST":
                return CreateUserStat(request, context);
            case "GET":
                return GetUserStat(request, context);
            case "PUT":
                return IncrementUserStat(request, context);
            case "DELETE":
                return DeleteUserStat(request, context);
            default:
                return new APIGatewayHttpApiV2ProxyResponse
                {
                    StatusCode = 400,
                    Body = "HTTP Request not supported",
                    Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
                };
        }
    }

    protected APIGatewayHttpApiV2ProxyResponse CreateResponseAndLogout(object? responseObj)
    {
        APIGatewayHttpApiV2ProxyResponse response;

        if (responseObj == null)
        {
            response = new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.NoContent,
                Body = "",
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };
        }
        else
        {
            response = new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonSerializer.Serialize(responseObj, responseObj.GetType()),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }

        _Sdk.Logout();
        return response;
    }

    protected APIGatewayHttpApiV2ProxyResponse ExecuteAction(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context, Func<string, string, object?> action)
    {
        try
        {
            string user_id = String.Empty;
            if (request.QueryStringParameters.ContainsKey("userid"))
                user_id = request.QueryStringParameters["userid"].Trim();
            if (user_id == String.Empty)
                throw new Exception("user id is not specified.");

            context.Logger.LogInformation("TargetUserId: " + user_id);

            _Sdk.LoginClient();

            object? responseObj = action.Invoke(user_id, request.Body);

            return CreateResponseAndLogout(responseObj);
        }
        catch (Exception x)
        {
            var response = new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Body = ("{\"error\":\"" + x.Message + "\"}"),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
            return response;
        }
    }

    public APIGatewayHttpApiV2ProxyResponse GetStatConfigurations(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("GetUserStat Request\n");

        _Sdk.LoginClient();

        StatConfiguration wStatConfig = new StatConfiguration(_Sdk);

        StatPagingSlicedResult? result = wStatConfig.GetStats(GetStats.Builder
            .SetOffset(0)
            .SetLimit(10)
            .Build(_Sdk.Namespace));
        if (result == null)
            throw new Exception("Null response from API");

        return CreateResponseAndLogout(result);
    }

    protected APIGatewayHttpApiV2ProxyResponse IncrementUserStat(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("IncrementUserStat Request\n");
        return ExecuteAction(request, context, (user_id, body) =>
        {
            UserStatistic wUserStatistic = new UserStatistic(_Sdk);

            StatItemInc? input = JsonSerializer.Deserialize<StatItemInc>(body);
            if (input == null)
                throw new Exception("Input is null");

            StatItemIncResult? incResult = wUserStatistic.IncUserStatItemValue(IncUserStatItemValue.Builder
                .SetBody(input)
                .Build(_Sdk.Namespace, _ActiveStatCode, user_id));

            return incResult;
        });
    }

    protected APIGatewayHttpApiV2ProxyResponse GetUserStat(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("GetUserStat Request\n");
        return ExecuteAction(request, context, (user_id, body) =>
        {
            UserStatistic wUserStatistic = new UserStatistic(_Sdk);

            UserStatItemPagingSlicedResult? result = wUserStatistic.GetUserStatItems(GetUserStatItems.Builder
                .SetLimit(10)
                .SetOffset(0)
                .SetStatCodes(_ActiveStatCode)
                .Build(_Sdk.Namespace, user_id));

            return result;
        });
    }

    protected APIGatewayHttpApiV2ProxyResponse CreateUserStat(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("CreateUserStat Request\n");
        return ExecuteAction(request, context, (user_id, body) =>
        {
            UserStatistic wUserStatistic = new UserStatistic(_Sdk);

            wUserStatistic.CreateUserStatItem(CreateUserStatItem.Builder
                .Build(_Sdk.Namespace, _ActiveStatCode, user_id));

            return null;
        });
    }

    protected APIGatewayHttpApiV2ProxyResponse DeleteUserStat(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("DeleteUserStat Request\n");
        return ExecuteAction(request, context, (user_id, body) =>
        {
            UserStatistic wUserStatistic = new UserStatistic(_Sdk);

            wUserStatistic.DeleteUserStatItems(DeleteUserStatItems.Builder
                .Build(_Sdk.Namespace, _ActiveStatCode, user_id));

            return null;
        });
    }
}