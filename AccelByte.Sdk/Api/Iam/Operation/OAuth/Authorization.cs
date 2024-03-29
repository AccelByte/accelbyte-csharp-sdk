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
    /// Authorization
    ///
    /// ## The endpoint is going to be deprecated
    /// The endpoint supports two response types:
    /// ### 1. Response Type == "code":
    /// The endpoint returns an authorization code that will be used by the IAM client to exchange for an access token. It supports two different headers, the basic and the bearer header. Each behaves differently.
    /// - **The basic header**
    /// The basic headerâs value is the base64 of the client ID and client secret. It is used by the developer whenever the developer authorizes a user on a same namespace.
    /// - **The bearer header**
    /// The bearer headerâs value is an access token. It is used by the developer whenever the developer authorizes a user on a different namespace. The endpoint validates userâs entitlement on the designated namespace for making sure the user is authorized for a designated namespace.
    /// 
    /// Following are the responses returned by the endpoint:
    /// - **Authorize success**: redirects to the given URL with the following information: ?code={authorization code}&state;={state}
    /// - **Authorize failure**: redirects to the given URL with the following information:?error=access_denied&error;_description=...
    /// 
    /// ### 2. Response Type == "token" (Implicit) is deprecated.
    /// ### Endpoint migration guide
    /// 
    /// - **Substitute endpoint (for: basic header style)**: _/iam/v3/oauth/authorize [GET]_
    /// - **Substitute endpoint (for: bearer header style)**:
    /// step1: /iam/v3/namespace/{namespace}/token/request [POST] => get code
    /// step2: /iam/v3/token/exchange [POST] => get token by step1's code
    /// - **Note:**
    /// 1. V3 is standard OAuth2 flow and support PKCE
    /// 2. Will not support implicit flow in v3.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class Authorization : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthorizationBuilder Builder { get => new AuthorizationBuilder(); }

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
                AuthorizationResponseType responseType
            )
            {
                Authorization op = new Authorization(this,
                    clientId,
                    redirectUri,
                    responseType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private Authorization(AuthorizationBuilder builder,
            string clientId,
            string redirectUri,
            AuthorizationResponseType responseType
        )
        {


            if (builder.Login is not null) FormParams["login"] = builder.Login;
            if (builder.Password is not null) FormParams["password"] = builder.Password;
            if (builder.Scope is not null) FormParams["scope"] = builder.Scope;
            if (builder.State is not null) FormParams["state"] = builder.State;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (redirectUri is not null) FormParams["redirect_uri"] = redirectUri;
            if (responseType is not null) FormParams["response_type"] = responseType.Value;




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
            AuthorizationResponseType responseType
        )
        {


            if (login is not null) FormParams["login"] = login;
            if (password is not null) FormParams["password"] = password;
            if (scope is not null) FormParams["scope"] = scope;
            if (state is not null) FormParams["state"] = state;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (redirectUri is not null) FormParams["redirect_uri"] = redirectUri;
            if (responseType is not null) FormParams["response_type"] = responseType.Value;




            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/authorize";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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

    public class AuthorizationResponseType : StringEnum<AuthorizationResponseType>
    {
        public static readonly AuthorizationResponseType Code
            = new AuthorizationResponseType("code");

        public static readonly AuthorizationResponseType Token
            = new AuthorizationResponseType("token");


        public static implicit operator AuthorizationResponseType(string value)
        {
            return NewValue(value);
        }

        public AuthorizationResponseType(string enumValue)
            : base(enumValue)
        {

        }
    }

}