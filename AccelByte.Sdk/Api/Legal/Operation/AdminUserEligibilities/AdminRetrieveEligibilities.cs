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
    /// adminRetrieveEligibilities
    ///
    /// Retrieve the active policies and its conformance status by userThis process only supports cross-namespace checking between game namespace and publisher namespace , that means if the active policy already accepted by the same user in publisher namespace, then it will also be considered as eligible in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:LEGAL", action=2 (READ)
    /// </summary>
    public class AdminRetrieveEligibilities : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRetrieveEligibilitiesBuilder Builder = new AdminRetrieveEligibilitiesBuilder();

        public class AdminRetrieveEligibilitiesBuilder
            : OperationBuilder<AdminRetrieveEligibilitiesBuilder>
        {
            
            
            public string? PublisherUserId { get; set; }
            
            
            
            internal AdminRetrieveEligibilitiesBuilder() { }


            public AdminRetrieveEligibilitiesBuilder SetPublisherUserId(string _publisherUserId)
            {
                PublisherUserId = _publisherUserId;
                return this;
            }




            public AdminRetrieveEligibilities Build(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                AdminRetrieveEligibilities op = new AdminRetrieveEligibilities(this,
                    namespace_,                    
                    userId,                    
                    clientId,                    
                    countryCode                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminRetrieveEligibilities(AdminRetrieveEligibilitiesBuilder builder,
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
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRetrieveEligibilities(
            string namespace_,            
            string userId,            
            string? publisherUserId,            
            string clientId,            
            string countryCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (publisherUserId != null) QueryParams["publisherUserId"] = publisherUserId;
            if (clientId != null) QueryParams["clientId"] = clientId;
            if (countryCode != null) QueryParams["countryCode"] = countryCode;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/users/{userId}/eligibilities";

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