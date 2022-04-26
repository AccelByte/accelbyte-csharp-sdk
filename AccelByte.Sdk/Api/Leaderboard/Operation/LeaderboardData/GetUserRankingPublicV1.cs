// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// getUserRankingPublicV1
    ///
    /// 
    /// 
    /// Get user ranking in leaderboard
    /// </summary>
    public class GetUserRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserRankingPublicV1Builder Builder = new GetUserRankingPublicV1Builder();

        public class GetUserRankingPublicV1Builder
            : OperationBuilder<GetUserRankingPublicV1Builder>
        {
            
            
            
            internal GetUserRankingPublicV1Builder() { }






            public GetUserRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV1 op = new GetUserRankingPublicV1(this,
                    leaderboardCode,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserRankingPublicV1(GetUserRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserRankingPublicV1(
            string leaderboardCode,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsUserRankingResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserRankingResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserRankingResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}