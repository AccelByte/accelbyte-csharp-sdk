// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminLinkPlatformAccount
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// Force linking platform account to user User Account. This endpoint intended for admin to forcefully link account to user.
    /// </summary>
    public class AdminLinkPlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminLinkPlatformAccountBuilder Builder = new AdminLinkPlatformAccountBuilder();

        public class AdminLinkPlatformAccountBuilder
            : OperationBuilder<AdminLinkPlatformAccountBuilder>
        {





            internal AdminLinkPlatformAccountBuilder() { }






            public AdminLinkPlatformAccount Build(
                ModelLinkPlatformAccountRequest body,
                string namespace_,
                string userId
            )
            {
                AdminLinkPlatformAccount op = new AdminLinkPlatformAccount(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminLinkPlatformAccount(AdminLinkPlatformAccountBuilder builder,
            ModelLinkPlatformAccountRequest body,
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

        public AdminLinkPlatformAccount(
            string namespace_,            
            string userId,            
            Model.ModelLinkPlatformAccountRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/link";

        public override HttpMethod Method => HttpMethod.Post;

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