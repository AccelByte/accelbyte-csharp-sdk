// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// PublicSubmitUserAccountDeletionRequest
    ///
    /// 
    /// 
    /// Requires valid user access token and password
    /// </summary>
    public class PublicSubmitUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSubmitUserAccountDeletionRequestBuilder Builder = new PublicSubmitUserAccountDeletionRequestBuilder();

        public class PublicSubmitUserAccountDeletionRequestBuilder
            : OperationBuilder<PublicSubmitUserAccountDeletionRequestBuilder>
        {
            
            
            
            internal PublicSubmitUserAccountDeletionRequestBuilder() { }






            public PublicSubmitUserAccountDeletionRequest Build(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicSubmitUserAccountDeletionRequest op = new PublicSubmitUserAccountDeletionRequest(this,
                    password,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicSubmitUserAccountDeletionRequest(PublicSubmitUserAccountDeletionRequestBuilder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSubmitUserAccountDeletionRequest(
            string namespace_,            
            string userId,            
            string password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/deletions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsRequestDeleteResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsRequestDeleteResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsRequestDeleteResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}