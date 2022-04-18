// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// BulkGetSessions
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Bulk get sessions.
    /// </summary>
    public class BulkGetSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetSessionsBuilder Builder = new BulkGetSessionsBuilder();

        public class BulkGetSessionsBuilder
            : OperationBuilder<BulkGetSessionsBuilder>
        {
            
            public string? MatchIDs { get; set; }
            
            internal BulkGetSessionsBuilder() { }


            public BulkGetSessionsBuilder SetMatchIDs(string _matchIDs)
            {
                MatchIDs = _matchIDs;
                return this;
            }




            public BulkGetSessions Build(
                string namespace_
            )
            {
                BulkGetSessions op = new BulkGetSessions(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkGetSessions(BulkGetSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.MatchIDs != null) QueryParams["matchIDs"] = builder.MatchIDs;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetSessions(
            string namespace_,            
            string? matchIDs            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (matchIDs != null) QueryParams["matchIDs"] = matchIDs;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelsMatchmakingResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsMatchmakingResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsMatchmakingResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}