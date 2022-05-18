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
    /// AdminSendVerificationCodeV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// The verification code is sent to email address.
    /// 
    /// 
    /// 
    /// 
    /// Available contexts for use :
    /// 
    /// 
    /// 
    /// 
    ///             1. UserAccountRegistration
    /// 
    /// 
    /// a context type used for verifying email address in user account registration. It returns 409 if the email address already verified.
    /// It is the default context if the Context field is empty
    /// 
    /// 
    /// 
    /// 
    /// 
    ///             2. UpdateEmailAddress
    /// 
    /// 
    /// a context type used for verify user before updating email address.(Without email address verified checking)
    /// 
    /// 
    /// 
    /// 
    /// 
    ///             3. upgradeHeadlessAccount
    /// 
    /// 
    /// The context is intended to be used whenever the email address wanted to be automatically verified on upgrading a headless account.
    /// If this context used, IAM rejects the request if the email address is already used by others by returning HTTP Status Code 409.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// action code: 10116
    /// </summary>
    public class AdminSendVerificationCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSendVerificationCodeV3Builder Builder = new AdminSendVerificationCodeV3Builder();

        public class AdminSendVerificationCodeV3Builder
            : OperationBuilder<AdminSendVerificationCodeV3Builder>
        {





            internal AdminSendVerificationCodeV3Builder() { }






            public AdminSendVerificationCodeV3 Build(
                ModelSendVerificationCodeRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminSendVerificationCodeV3 op = new AdminSendVerificationCodeV3(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminSendVerificationCodeV3(AdminSendVerificationCodeV3Builder builder,
            ModelSendVerificationCodeRequestV3 body,
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

        public AdminSendVerificationCodeV3(
            string namespace_,            
            string userId,            
            Model.ModelSendVerificationCodeRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/code/request";

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