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
    /// CreateArchivedLeaderboardRankingDataV1Handler
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [CREATE]'
    /// 
    /// 
    /// 
    /// 
    /// Archive leaderboard ranking data for specified leaderboard codes. NOTE: This will remove all data of the leaderboard on every slug,
    /// remove the leaderboard code on stat mapping, and remove the leaderboard on the queue reset. This will be a bulk endpoint
    /// </summary>
    public class CreateArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateArchivedLeaderboardRankingDataV1HandlerBuilder Builder = new CreateArchivedLeaderboardRankingDataV1HandlerBuilder();

        public class CreateArchivedLeaderboardRankingDataV1HandlerBuilder
            : OperationBuilder<CreateArchivedLeaderboardRankingDataV1HandlerBuilder>
        {
            
            
            internal CreateArchivedLeaderboardRankingDataV1HandlerBuilder() { }






            public CreateArchivedLeaderboardRankingDataV1Handler Build(
                ModelsArchiveLeaderboardReq body,
                string namespace_
            )
            {
                CreateArchivedLeaderboardRankingDataV1Handler op = new CreateArchivedLeaderboardRankingDataV1Handler(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateArchivedLeaderboardRankingDataV1Handler(CreateArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            ModelsArchiveLeaderboardReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateArchivedLeaderboardRankingDataV1Handler(
            string namespace_,            
            Model.ModelsArchiveLeaderboardReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}