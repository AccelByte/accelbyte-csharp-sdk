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
    /// indirectBulkAcceptVersionedPolicyV2
    ///
    ///  IMPORTANT: GOING TO DEPRECATE
    /// 
    /// Accepts many legal policy versions all at once. Supply with localized version policy id, version policy id, policy id, userId, namespace, country code and client id to accept an agreement. This endpoint used by APIGateway during new user registration.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:LEGAL", action=1 (CREATE)
    /// </summary>
    public class IndirectBulkAcceptVersionedPolicyV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IndirectBulkAcceptVersionedPolicyV2Builder Builder = new IndirectBulkAcceptVersionedPolicyV2Builder();

        public class IndirectBulkAcceptVersionedPolicyV2Builder
            : OperationBuilder<IndirectBulkAcceptVersionedPolicyV2Builder>
        {
            
            
            
            
            public List<Model.AcceptAgreementRequest>? Body { get; set; }
            
            internal IndirectBulkAcceptVersionedPolicyV2Builder() { }



            public IndirectBulkAcceptVersionedPolicyV2Builder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public IndirectBulkAcceptVersionedPolicyV2 Build(
                string clientId,
                string countryCode,
                string namespace_,
                string userId
            )
            {
                IndirectBulkAcceptVersionedPolicyV2 op = new IndirectBulkAcceptVersionedPolicyV2(this,
                    clientId,                    
                    countryCode,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private IndirectBulkAcceptVersionedPolicyV2(IndirectBulkAcceptVersionedPolicyV2Builder builder,
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
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public IndirectBulkAcceptVersionedPolicyV2(
            string clientId,            
            string countryCode,            
            string namespace_,            
            string userId,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AcceptAgreementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}