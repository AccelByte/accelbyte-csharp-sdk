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
    /// StoreMatchResults
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHRESULT [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Process match result into final attribute value and stores it to player attribute
    /// 
    /// Will return final attribute value
    /// </summary>
    public class StoreMatchResults : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static StoreMatchResultsBuilder Builder = new StoreMatchResultsBuilder();

        public class StoreMatchResultsBuilder
            : OperationBuilder<StoreMatchResultsBuilder>
        {
            
            
            internal StoreMatchResultsBuilder() { }





            public StoreMatchResults Build(
                ModelsMatchResultRequest body,
                string namespace_
            )
            {
                StoreMatchResults op = new StoreMatchResults(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private StoreMatchResults(StoreMatchResultsBuilder builder,
            ModelsMatchResultRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public StoreMatchResults(
            string namespace_,            
            Model.ModelsMatchResultRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/matchresult";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsMatchResultResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchResultResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchResultResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}