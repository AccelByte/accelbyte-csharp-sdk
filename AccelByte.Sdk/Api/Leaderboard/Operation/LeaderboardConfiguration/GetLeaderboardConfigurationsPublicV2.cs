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
    /// GetLeaderboardConfigurationsPublicV2
    ///
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationsPublicV2Builder Builder = new GetLeaderboardConfigurationsPublicV2Builder();

        public class GetLeaderboardConfigurationsPublicV2Builder
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetLeaderboardConfigurationsPublicV2Builder() { }


            public GetLeaderboardConfigurationsPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLeaderboardConfigurationsPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetLeaderboardConfigurationsPublicV2 Build(
                string namespace_
            )
            {
                return new GetLeaderboardConfigurationsPublicV2(this,
                    namespace_                    
                );
            }
        }

        private GetLeaderboardConfigurationsPublicV2(GetLeaderboardConfigurationsPublicV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public GetLeaderboardConfigurationsPublicV2(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/leaderboard/v2/public/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.V2GetAllLeaderboardConfigsPublicResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.V2GetAllLeaderboardConfigsPublicResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.V2GetAllLeaderboardConfigsPublicResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}