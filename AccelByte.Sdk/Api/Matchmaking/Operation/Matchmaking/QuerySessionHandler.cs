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
    /// QuerySessionHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:SESSION [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Queries the specified session's status. Game servers are expected to
    /// call this periodically as long as it has a session in queue to see
    /// if there are new players being matched to the session.
    /// 
    /// Possible session statuses are "sessionInQueue", "sessionFull", and "sessionTimeout".
    /// </summary>
    public class QuerySessionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySessionHandlerBuilder Builder = new QuerySessionHandlerBuilder();

        public class QuerySessionHandlerBuilder
            : OperationBuilder<QuerySessionHandlerBuilder>
        {
            
            
            internal QuerySessionHandlerBuilder() { }





            public QuerySessionHandler Build(
                string matchID,
                string namespace_
            )
            {
                QuerySessionHandler op = new QuerySessionHandler(this,
                    matchID,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QuerySessionHandler(QuerySessionHandlerBuilder builder,
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QuerySessionHandler(
            string matchID,            
            string namespace_            
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/sessions/{matchID}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsMatchmakingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}