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

    protected APIGatewayProxyResponse CreateResponseAndLogout(object? responseObj)
    {
        APIGatewayProxyResponse response;

        if (responseObj == null)
        {
            response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.NoContent,
                Body = "",
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };
        }
        else
        {
            response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonSerializer.Serialize(responseObj, responseObj.GetType()),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }

        _Sdk.Logout();
        return response;
    }

    protected APIGatewayProxyResponse ExecuteAction(APIGatewayProxyRequest request, ILambdaContext context, Func<string, string, object?> action)
    {
        try
        {
            string user_id = String.Empty;
            if (request.PathParameters.ContainsKey("userid"))
                user_id = request.PathParameters["userid"].Trim();
            if (user_id == String.Empty)
                throw new Exception("user id is not specified.");

            context.Logger.LogInformation("TargetUserId: " + user_id);
                      
            _Sdk.LoginClient();

            object? responseObj = action.Invoke(user_id, request.Body);

            return CreateResponseAndLogout(responseObj);
        }
        catch (Exception x)
        {
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Body = ("{\"error\":\"" + x.Message + "\"}"),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
            return response;
        }
    }

    public APIGatewayProxyResponse GetStatConfigurations(APIGatewayProxyRequest request, ILambdaContext context)
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

    public APIGatewayProxyResponse GetUserStat(APIGatewayProxyRequest request, ILambdaContext context)
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

    public APIGatewayProxyResponse CreateUserStat(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("CreateUserStat Request\n");
        return ExecuteAction(request, context, (user_id, body) =>
        {
            UserStatistic wUserStatistic = new UserStatistic(_Sdk);

            wUserStatistic.CreateUserStatItem(CreateUserStatItem.Builder
                .Build(_Sdk.Namespace,_ActiveStatCode, user_id));

            return null;
        });
    }

    public APIGatewayProxyResponse IncrementUserStat(APIGatewayProxyRequest request, ILambdaContext context)
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

    public APIGatewayProxyResponse DeleteUserStat(APIGatewayProxyRequest request, ILambdaContext context)
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