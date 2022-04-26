// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminDisableUserV2
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:USERSTATUS:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// For Deletion Account purpose fill the reason with:
    /// 
    /// 
    /// 
    /// 
    ///           * DeactivateAccount : if your deletion request comes from user
    /// 
    /// 
    ///           * AdminDeactivateAccount : if your deletion request comes from admin
    /// </summary>
    public class AdminDisableUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableUserV2Builder Builder = new AdminDisableUserV2Builder();

        public class AdminDisableUserV2Builder
            : OperationBuilder<AdminDisableUserV2Builder>
        {
            
            
            
            internal AdminDisableUserV2Builder() { }






            public AdminDisableUserV2 Build(
                ModelDisableUserRequest body,
                string namespace_,
                string userId
            )
            {
                AdminDisableUserV2 op = new AdminDisableUserV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDisableUserV2(AdminDisableUserV2Builder builder,
            ModelDisableUserRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDisableUserV2(
            string namespace_,            
            string userId,            
            Model.ModelDisableUserRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}