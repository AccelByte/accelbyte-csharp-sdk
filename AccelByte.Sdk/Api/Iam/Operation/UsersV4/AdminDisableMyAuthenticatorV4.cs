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
    /// AdminDisableMyAuthenticatorV4
    ///
    /// 
    /// 
    /// This endpoint is used to disable 2FA authenticator.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminDisableMyAuthenticatorV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableMyAuthenticatorV4Builder Builder = new AdminDisableMyAuthenticatorV4Builder();

        public class AdminDisableMyAuthenticatorV4Builder
            : OperationBuilder<AdminDisableMyAuthenticatorV4Builder>
        {
            internal AdminDisableMyAuthenticatorV4Builder() { }





            public AdminDisableMyAuthenticatorV4 Build(
            )
            {
                AdminDisableMyAuthenticatorV4 op = new AdminDisableMyAuthenticatorV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDisableMyAuthenticatorV4(AdminDisableMyAuthenticatorV4Builder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDisableMyAuthenticatorV4(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/authenticator/disable";

        public override HttpMethod Method => HttpMethod.Delete;

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