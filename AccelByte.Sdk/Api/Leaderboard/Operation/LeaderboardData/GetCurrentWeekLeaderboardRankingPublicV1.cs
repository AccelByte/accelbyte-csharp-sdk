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
    /// GetCurrentWeekLeaderboardRankingPublicV1
    ///
    /// 
    /// 
    /// Get rankings in current week leaderboard.
    /// </summary>
    public class GetCurrentWeekLeaderboardRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentWeekLeaderboardRankingPublicV1Builder Builder = new GetCurrentWeekLeaderboardRankingPublicV1Builder();

        public class GetCurrentWeekLeaderboardRankingPublicV1Builder
            : OperationBuilder<GetCurrentWeekLeaderboardRankingPublicV1Builder>
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetCurrentWeekLeaderboardRankingPublicV1Builder() { }


            public GetCurrentWeekLeaderboardRankingPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetCurrentWeekLeaderboardRankingPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetCurrentWeekLeaderboardRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentWeekLeaderboardRankingPublicV1 op = new GetCurrentWeekLeaderboardRankingPublicV1(this,
                    leaderboardCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetCurrentWeekLeaderboardRankingPublicV1(GetCurrentWeekLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCurrentWeekLeaderboardRankingPublicV1(
            string leaderboardCode,            
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/week";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetLeaderboardRankingResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}