// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Web;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Repository;

using AccelByte.Sdk.Sample.TicTacToe;
using AccelByte.Sdk.Sample.TicTacToe.Model;
using AccelByte.Sdk.Sample.TicTacToe.Web;

using HttpMultipartParser;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AccelByte.Sdk.Sample.TicTacToe.Lambda;

public class Functions
{
    /// <summary>
    /// Default constructor that Lambda will invoke.
    /// </summary>
    public Functions()
    {

    }

    protected AccelByteSDK CreateSdk()
    {
        HttpClientPolicy policy = HttpClientPolicy.Default;
        policy.MaxRetryCount = 1000;
        policy.RetryInterval = 1000;

        //retry logic for claim server if server is not ready
        policy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");

        AccelByteSDK sdk = AccelByteSDK.Builder
            .SetHttpClient(ReliableHttpClient.Builder
                .SetDefaultPolicy(policy)
                .Build())
            .UseDefaultTokenRepository()
            .UseDefaultConfigRepository()
            .Build();
        sdk.LoginClient();
        return sdk;
    }

    protected string GetAuthToken(APIGatewayProxyRequest request)
    {
        if (!request.Headers.ContainsKey("Authorization"))
            throw new APIException("not authorized", 0, 401);
        string[] authzParts = request.Headers["Authorization"].Split(' ', 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (authzParts.Length < 2)
            throw new APIException("invalid authorization", 0, 401);
        return authzParts[1];
    }

    protected APIGatewayProxyResponse WrapLogic(APIGatewayProxyRequest request, Func<string, string, TicTacToeServer, object?> logicFunc)
    {
        try
        {
            string authToken = GetAuthToken(request);
            TicTacToeServer t3server = new TicTacToeServer(CreateSdk(), new RedisCacheProvider());

            string userId = String.Empty;
            if (authToken != String.Empty)
                userId = t3server.ValidateAuthToken(authToken);

            object? output = logicFunc(authToken, userId, t3server);
            if (output == null)
            {
                return new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.NoContent,
                    Body = "",
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
                };
            }
            else
            {
                return new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonSerializer.Serialize(output),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
                };
            }
        }
        catch (APIException ex)
        {
            return new APIGatewayProxyResponse
            {
                StatusCode = ex.StatusCode,
                Body = ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };
        }
        catch (Exception ex)
        {
            return new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Body = ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };
        }
    }

    /// <summary>
    /// A Lambda function to respond to HTTP Get methods from API Gateway
    /// </summary>
    /// <param name="request"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "Hello AWS Serverless",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }

    /// <summary>
    /// Get active matches
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse GetMatches(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("GetMatches\n");
        return WrapLogic(request, (authToken, userId, t3) =>
        {
            if (userId == String.Empty)
                throw new APIException("not authorized", 0, 403);

            List<MatchItem> matches = t3.GetActiveMatches();
            return matches;
        });
    }

    /// <summary>
    /// Start a match
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse StartMatch(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("StartMatch\n");
        return WrapLogic(request, (authToken, userId, t3) =>
        {
            if (userId == String.Empty)
                throw new APIException("not authorized", 0, 403);

            NewGameResult result = t3.NewGame(userId);
            return result;
        });
    }

    /// <summary>
    /// Join an existing match
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse JoinMatch(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("JoinMatch\n");
        return WrapLogic(request, (authToken, userId, t3) =>
        {
            if (userId == String.Empty)
                throw new APIException("not authorized", 0, 403);

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(request.Body));
            MultipartFormDataParser formData = MultipartFormDataParser.Parse(ms, Encoding.UTF8);

            string match_id = String.Empty;
            if (formData.HasParameter("match_id"))
                match_id = formData.GetParameterValue("match_id").Trim();
            if (match_id == String.Empty)
                throw new APIException("unspecified match id", 0, 400);

            NewGameResult result = t3.JoinGame(userId, match_id);
            return result;
        });
    }

    /// <summary>
    /// Make a move for player
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse MakeAMove(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("MakeAMove\n");
        return WrapLogic(request, (authToken, userId, t3) =>
        {
            if (userId == String.Empty)
                throw new APIException("not authorized", 0, 403);

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(request.Body));
            MultipartFormDataParser formData = MultipartFormDataParser.Parse(ms, Encoding.UTF8);

            string match_id = String.Empty;
            if (formData.HasParameter("match_id"))
                match_id = formData.GetParameterValue("match_id").Trim();
            if (match_id == String.Empty)
                throw new APIException("unspecified match id", 0, 400);

            string s_row = String.Empty;
            if (formData.HasParameter("row"))
                s_row = formData.GetParameterValue("row").Trim();
            int row = -1;
            if (!int.TryParse(s_row, out row))
                throw new APIException("invalid row value", 0, 400);

            string s_col = String.Empty;
            if (formData.HasParameter("column"))
                s_col = formData.GetParameterValue("column").Trim();
            int col = -1;
            if (!int.TryParse(s_col, out col))
                throw new APIException("invalid column value", 0, 400);

            t3.Move(userId, match_id, row, col);

            return null;
        });
    }
}