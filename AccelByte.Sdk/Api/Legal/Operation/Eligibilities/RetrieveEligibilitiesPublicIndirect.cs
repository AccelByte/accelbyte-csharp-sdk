// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveEligibilitiesPublicIndirect
    ///
    /// Retrieve the active policies and its conformance status by userThis process only supports cross-namespace checking between game namespace and publisher namespace , that means if the active policy already accepted by the same user in publisher namespace, then it will also be considered as eligible in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class RetrieveEligibilitiesPublicIndirect : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveEligibilitiesPublicIndirectBuilder Builder = new RetrieveEligibilitiesPublicIndirectBuilder();

        public class RetrieveEligibilitiesPublicIndirectBuilder
            : OperationBuilder<RetrieveEligibilitiesPublicIndirectBuilder>
        {
            
            
            
            
            internal RetrieveEligibilitiesPublicIndirectBuilder() { }





            public RetrieveEligibilitiesPublicIndirect Build(
                string clientId,
                string countryCode,
                string namespace_,
                string userId
            )
            {
                RetrieveEligibilitiesPublicIndirect op = new RetrieveEligibilitiesPublicIndirect(this,
                    clientId,                    
                    countryCode,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveEligibilitiesPublicIndirect(RetrieveEligibilitiesPublicIndirectBuilder builder,
            string clientId,
            string countryCode,
            string namespace_,
            string userId
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveEligibilitiesPublicIndirect(
            string clientId,            
            string countryCode,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/eligibilities/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.RetrieveUserEligibilitiesIndirectResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveUserEligibilitiesIndirectResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveUserEligibilitiesIndirectResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}