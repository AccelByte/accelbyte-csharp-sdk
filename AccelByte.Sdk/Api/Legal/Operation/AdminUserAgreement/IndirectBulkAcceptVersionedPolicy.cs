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
    /// indirectBulkAcceptVersionedPolicy
    ///
    /// Accepts many legal policy versions all at once. Supply with localized version policy id and userId to accept an agreement. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:LEGAL", action=1 (CREATE)
    /// </summary>
    public class IndirectBulkAcceptVersionedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IndirectBulkAcceptVersionedPolicyBuilder Builder = new IndirectBulkAcceptVersionedPolicyBuilder();

        public class IndirectBulkAcceptVersionedPolicyBuilder
            : OperationBuilder<IndirectBulkAcceptVersionedPolicyBuilder>
        {
            
            
            public string? PublisherUserId { get; set; }
            
            
            
            public List<Model.AcceptAgreementRequest>? Body { get; set; }
            
            internal IndirectBulkAcceptVersionedPolicyBuilder() { }


            public IndirectBulkAcceptVersionedPolicyBuilder SetPublisherUserId(string _publisherUserId)
            {
                PublisherUserId = _publisherUserId;
                return this;
            }


            public IndirectBulkAcceptVersionedPolicyBuilder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public IndirectBulkAcceptVersionedPolicy Build(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                IndirectBulkAcceptVersionedPolicy op = new IndirectBulkAcceptVersionedPolicy(this,
                    namespace_,                    
                    userId,                    
                    clientId,                    
                    countryCode                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private IndirectBulkAcceptVersionedPolicy(IndirectBulkAcceptVersionedPolicyBuilder builder,
            string namespace_,
            string userId,
            string clientId,
            string countryCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.PublisherUserId != null) QueryParams["publisherUserId"] = builder.PublisherUserId;
            if (clientId != null) QueryParams["clientId"] = clientId;
            if (countryCode != null) QueryParams["countryCode"] = countryCode;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public IndirectBulkAcceptVersionedPolicy(
            string namespace_,            
            string userId,            
            string? publisherUserId,            
            string clientId,            
            string countryCode,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (publisherUserId != null) QueryParams["publisherUserId"] = publisherUserId;
            if (clientId != null) QueryParams["clientId"] = clientId;
            if (countryCode != null) QueryParams["countryCode"] = countryCode;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/users/{userId}/agreements/policies";

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