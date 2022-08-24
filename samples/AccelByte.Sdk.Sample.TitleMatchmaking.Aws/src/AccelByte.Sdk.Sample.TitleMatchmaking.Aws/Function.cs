// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AccelByte.Sdk.Sample.TitleMatchmaking.Aws;

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

        return AccelByteSDK.Builder
            .SetHttpClient(ReliableHttpClient.Builder
                .SetDefaultPolicy(policy)
                .Build())
            .UseDefaultTokenRepository()
            .UseDefaultConfigRepository()
            .Build();
    }

    /// <summary>
    /// A Lambda function to respond to HTTP Get methods from API Gateway
    /// </summary>
    /// <param name="request"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse GetTest(APIGatewayProxyRequest request, ILambdaContext context)
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
    /// A Lambda function to process Title Matchmaking from client app
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse PostTitleMatchmaking(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("PostTitleMatchmaking\n");
        try
        {
            if (!request.Headers.ContainsKey("Authorization"))
                throw new APIException("not authorized", 0, 401);
            string[] authzParts = request.Headers["Authorization"].Split(' ', 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (authzParts.Length < 2)
                throw new APIException("invalid authorization", 0, 401);

            AccelByteSDK sdk = CreateSdk();
            sdk.LoginClient();

            ICacheProvider cache = new RedisCacheProvider();
            Matchmaker mm = new Matchmaker(sdk, cache, "csharp_tm_gm_");
            MatchmakingResult mResult = mm.CreateMatchmakingRequest(authzParts[1]);

            if (!mResult.IsFirstMember)
                mm.CreateSessionAndClaimServer(mResult);

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonSerializer.Serialize(mResult),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
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
}