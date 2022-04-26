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
    /// getUserLeaderboardRankingsAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Get user leaderboard rankings
    /// </summary>
    public class GetUserLeaderboardRankingsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserLeaderboardRankingsAdminV1Builder Builder = new GetUserLeaderboardRankingsAdminV1Builder();

        public class GetUserLeaderboardRankingsAdminV1Builder
            : OperationBuilder<GetUserLeaderboardRankingsAdminV1Builder>
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetUserLeaderboardRankingsAdminV1Builder() { }


            public GetUserLeaderboardRankingsAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserLeaderboardRankingsAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserLeaderboardRankingsAdminV1 Build(
                string namespace_,
                string userId
            )
            {
                GetUserLeaderboardRankingsAdminV1 op = new GetUserLeaderboardRankingsAdminV1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserLeaderboardRankingsAdminV1(GetUserLeaderboardRankingsAdminV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserLeaderboardRankingsAdminV1(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetAllUserLeaderboardsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}