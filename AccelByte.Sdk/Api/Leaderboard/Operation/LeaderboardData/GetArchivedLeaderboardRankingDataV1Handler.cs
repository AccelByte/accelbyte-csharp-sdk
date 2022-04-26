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
    /// GetArchivedLeaderboardRankingDataV1Handler
    ///
    /// 
    /// 
    /// Get signed url in an all time leaderboard that archived. NOTE: This will be a bulk endpoint to get sign url
    /// </summary>
    public class GetArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetArchivedLeaderboardRankingDataV1HandlerBuilder Builder = new GetArchivedLeaderboardRankingDataV1HandlerBuilder();

        public class GetArchivedLeaderboardRankingDataV1HandlerBuilder
            : OperationBuilder<GetArchivedLeaderboardRankingDataV1HandlerBuilder>
        {
            
            
            public string? Slug { get; set; }
            
            
            internal GetArchivedLeaderboardRankingDataV1HandlerBuilder() { }


            public GetArchivedLeaderboardRankingDataV1HandlerBuilder SetSlug(string _slug)
            {
                Slug = _slug;
                return this;
            }





            public GetArchivedLeaderboardRankingDataV1Handler Build(
                string leaderboardCode,
                string namespace_,
                string leaderboardCodes
            )
            {
                GetArchivedLeaderboardRankingDataV1Handler op = new GetArchivedLeaderboardRankingDataV1Handler(this,
                    leaderboardCode,                    
                    namespace_,                    
                    leaderboardCodes                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetArchivedLeaderboardRankingDataV1Handler(GetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string leaderboardCode,
            string namespace_,
            string leaderboardCodes
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (builder.Slug != null) QueryParams["slug"] = builder.Slug;
            if (leaderboardCodes != null) QueryParams["leaderboardCodes"] = leaderboardCodes;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetArchivedLeaderboardRankingDataV1Handler(
            string leaderboardCode,            
            string namespace_,            
            string? slug,            
            string leaderboardCodes            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (slug != null) QueryParams["slug"] = slug;
            if (leaderboardCodes != null) QueryParams["leaderboardCodes"] = leaderboardCodes;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/archived";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}