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
    /// Authorization
    ///
    /// The endpoint supports two response types:
    /// 
    /// 
    /// 
    /// 1. Response Type == "code":
    /// 
    /// 
    /// 
    /// 
    /// The endpoint returns an authorization code that will be used by the IAM client to exchange for an access token. It supports two different headers, the basic and the bearer header. Each behaves differently.
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// The basic header
    /// 
    /// 
    /// 
    /// 
    /// The basic headerâs value is the base64 of the client ID and client secret. It is used by the developer whenever the developer authorizes a user on a same namespace.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// The bearer header
    /// 
    /// 
    /// 
    /// 
    /// The bearer headerâs value is an access token. It is used by the developer whenever the developer authorizes a user on a different namespace. The endpoint validates userâs entitlement on the designated namespace for making sure the user is authorized for a designated namespace.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Following are the responses returned by the endpoint:
    /// 
    /// 
    /// 
    /// 
    ///         *  Authorize success : redirects to the given URL with the following information: ?code={authorization code}&state;={state}
    /// 
    /// 
    /// 
    ///         *  Authorize failure : redirects to the given URL with the following information:?error=access_denied&error;_description=...
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 2. Response Type == "token":
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// Authorize success : redirects to the given URL with the following information:
    /// 
    /// 
    /// 
    /// 
    /// #access_token={accesstoken}&expires;_in={expiration duration in seconds}&token;_type=Bearer
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// Authorize failure : redirects to the given URL with the following information:
    /// 
    /// 
    /// 
    /// 
    /// ?error=access_denied&error;_description=...
    /// </summary>
    public class Authorization : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthorizationBuilder Builder = new AuthorizationBuilder();

        public class AuthorizationBuilder
            : OperationBuilder<AuthorizationBuilder>
        {
            public string? Login { get; set; }
            
            public string? Password { get; set; }
            
            public string? Scope { get; set; }
            
            public string? State { get; set; }
            
            
            
            
            internal AuthorizationBuilder() { }




            public AuthorizationBuilder SetLogin(string _login)
            {
                Login = _login;
                return this;
            }

            public AuthorizationBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }

            public AuthorizationBuilder SetScope(string _scope)
            {
                Scope = _scope;
                return this;
            }

            public AuthorizationBuilder SetState(string _state)
            {
                State = _state;
                return this;
            }


            public Authorization Build(
                string clientId,
                string redirectUri,
                string responseType
            )
            {
                Authorization op = new Authorization(this,
                    clientId,                    
                    redirectUri,                    
                    responseType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private Authorization(AuthorizationBuilder builder,
            string clientId,
            string redirectUri,
            string responseType
        )
        {
            
            
            if (builder.Login != null) FormParams["login"] = builder.Login;
            if (builder.Password != null) FormParams["password"] = builder.Password;
            if (builder.Scope != null) FormParams["scope"] = builder.Scope;
            if (builder.State != null) FormParams["state"] = builder.State;
            if (clientId != null) FormParams["client_id"] = clientId;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (responseType != null) FormParams["response_type"] = responseType;
            
            
            
            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Authorization(
            string? login,            
            string? password,            
            string? scope,            
            string? state,            
            string clientId,            
            string redirectUri,            
            string responseType            
        )
        {
            
            
            if (login != null) FormParams["login"] = login;
            if (password != null) FormParams["password"] = password;
            if (scope != null) FormParams["scope"] = scope;
            if (state != null) FormParams["state"] = state;
            if (clientId != null) FormParams["client_id"] = clientId;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (responseType != null) FormParams["response_type"] = responseType;
            
            
            
            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/authorize";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            if (code == (HttpStatusCode)302)
            {
              return payloadString;
            }
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}