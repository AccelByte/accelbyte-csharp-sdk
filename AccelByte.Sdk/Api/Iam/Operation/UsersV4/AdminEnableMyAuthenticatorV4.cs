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
    /// AdminEnableMyAuthenticatorV4
    ///
    /// 
    /// 
    /// (In Development)This endpoint is used to enable 2FA authenticator.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminEnableMyAuthenticatorV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableMyAuthenticatorV4Builder Builder = new AdminEnableMyAuthenticatorV4Builder();

        public class AdminEnableMyAuthenticatorV4Builder
        {
            public string? Code { get; set; }
            
            internal AdminEnableMyAuthenticatorV4Builder() { }




            public AdminEnableMyAuthenticatorV4Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }


            public AdminEnableMyAuthenticatorV4 Build(
            )
            {
                return new AdminEnableMyAuthenticatorV4(this
                );
            }
        }

        private AdminEnableMyAuthenticatorV4(AdminEnableMyAuthenticatorV4Builder builder
        )
        {
            
            
            if (builder.Code != null) FormParams["code"] = builder.Code;
            
            
            
        }
        #endregion

        public AdminEnableMyAuthenticatorV4(
            string? code            
        )
        {
            
            
            if (code != null) FormParams["code"] = code;
            
            
            
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/authenticator/enable";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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