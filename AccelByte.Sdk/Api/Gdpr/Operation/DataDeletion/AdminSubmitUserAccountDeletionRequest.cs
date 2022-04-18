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
    /// AdminSubmitUserAccountDeletionRequest
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [CREATE]` and scope `account`
    /// </summary>
    public class AdminSubmitUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSubmitUserAccountDeletionRequestBuilder Builder = new AdminSubmitUserAccountDeletionRequestBuilder();

        public class AdminSubmitUserAccountDeletionRequestBuilder
            : OperationBuilder<AdminSubmitUserAccountDeletionRequestBuilder>
        {
            
            
            internal AdminSubmitUserAccountDeletionRequestBuilder() { }





            public AdminSubmitUserAccountDeletionRequest Build(
                string namespace_,
                string userId
            )
            {
                AdminSubmitUserAccountDeletionRequest op = new AdminSubmitUserAccountDeletionRequest(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminSubmitUserAccountDeletionRequest(AdminSubmitUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSubmitUserAccountDeletionRequest(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions";

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