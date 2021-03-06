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
    /// AuthenticationWithPlatformLinkV3
    ///
    /// 
    /// 
    /// This endpoint is being used to authenticate a user account and perform platform link.
    /// It validates user's email / username and password. If user already enable 2FA,
    /// invoke ''/mfa/verify' with response's mfa_token'
    /// </summary>
    public class AuthenticationWithPlatformLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthenticationWithPlatformLinkV3Builder Builder = new AuthenticationWithPlatformLinkV3Builder();

        public class AuthenticationWithPlatformLinkV3Builder
            : OperationBuilder<AuthenticationWithPlatformLinkV3Builder>
        {



            public bool? ExtendExp { get; set; }



            internal AuthenticationWithPlatformLinkV3Builder() { }




            public AuthenticationWithPlatformLinkV3Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }



            public AuthenticationWithPlatformLinkV3 Build(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV3 op = new AuthenticationWithPlatformLinkV3(this,
                    clientId,                    
                    linkingToken,                    
                    password,                    
                    username                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AuthenticationWithPlatformLinkV3(AuthenticationWithPlatformLinkV3Builder builder,
            string clientId,
            string linkingToken,
            string password,
            string username
        )
        {
            
            
            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;
            if (password is not null) FormParams["password"] = password;
            if (username is not null) FormParams["username"] = username;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AuthenticationWithPlatformLinkV3(
            bool? extendExp,            
            string clientId,            
            string linkingToken,            
            string password,            
            string username            
        )
        {
            
            
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;
            if (password is not null) FormParams["password"] = password;
            if (username is not null) FormParams["username"] = username;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/authenticateWithLink";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}