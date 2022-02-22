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
    /// GetAllTimeLeaderboardRankingPublicV1
    ///
    /// 
    /// 
    /// Get rankings in an all time leaderboard.
    /// </summary>
    public class GetAllTimeLeaderboardRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllTimeLeaderboardRankingPublicV1Builder Builder = new GetAllTimeLeaderboardRankingPublicV1Builder();

        public class GetAllTimeLeaderboardRankingPublicV1Builder
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetAllTimeLeaderboardRankingPublicV1Builder() { }


            public GetAllTimeLeaderboardRankingPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetAllTimeLeaderboardRankingPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetAllTimeLeaderboardRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                return new GetAllTimeLeaderboardRankingPublicV1(this,
                    leaderboardCode,                    
                    namespace_                    
                );
            }
        }

        private GetAllTimeLeaderboardRankingPublicV1(GetAllTimeLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public GetAllTimeLeaderboardRankingPublicV1(
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
            
            
            
            
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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