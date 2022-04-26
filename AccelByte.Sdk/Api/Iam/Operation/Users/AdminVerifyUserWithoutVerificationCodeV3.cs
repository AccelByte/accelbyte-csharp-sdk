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
    /// AdminVerifyUserWithoutVerificationCodeV3
    ///
    /// 
    /// 
    /// This endpoint force verify user. Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// action code: 10118
    /// </summary>
    public class AdminVerifyUserWithoutVerificationCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminVerifyUserWithoutVerificationCodeV3Builder Builder = new AdminVerifyUserWithoutVerificationCodeV3Builder();

        public class AdminVerifyUserWithoutVerificationCodeV3Builder
            : OperationBuilder<AdminVerifyUserWithoutVerificationCodeV3Builder>
        {
            
            
            internal AdminVerifyUserWithoutVerificationCodeV3Builder() { }






            public AdminVerifyUserWithoutVerificationCodeV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminVerifyUserWithoutVerificationCodeV3 op = new AdminVerifyUserWithoutVerificationCodeV3(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminVerifyUserWithoutVerificationCodeV3(AdminVerifyUserWithoutVerificationCodeV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminVerifyUserWithoutVerificationCodeV3(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/verify";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

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