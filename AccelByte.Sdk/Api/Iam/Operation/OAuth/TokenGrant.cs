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
    /// TokenGrant
    ///
    /// 
    /// 
    /// This endpoint requires all requests to have `Authorization` header set with `Basic` access authentication
    /// constructed from client id and client secret.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint supports different grant types :
    /// 
    /// 
    /// 
    ///         1. Grant Type == `client_credentials`:
    /// 
    ///     This endpoint will check the client credentials provided through Authorization header.
    /// 
    /// 
    ///         2. Grant Type == `password`:
    /// 
    ///     The grant type to use for authenticating a user, whether it's by email / username and password combination
    /// or through platform.
    /// 
    /// 
    ///         3. Grant Type == `refresh_token`:
    /// 
    ///     Used to get a new access token for a valid refresh token.
    /// 
    /// 
    ///         4. Grant Type == `authorization_code`:
    /// 
    ///     It generates the user token by given the authorization
    /// code which generated in "/authorize" API response. It should also pass
    /// in the redirect_uri, which should be the same as generating the
    /// authorization code request.
    /// 
    /// 
    /// 
    /// For platform authentication, use grant type `password`.
    /// The `username` field would be in form of
    /// `platform:<platform type>`, for example
    /// `platform:steam` for Steam. For the `password`
    /// field, set it to the authentication/authorization ticket or token obtainable through the
    /// respective platform SDK after authenticated the user to the platform. Supported platforms:
    /// 
    /// 
    /// 
    ///         * steam - use `platform:steam` as the username and use the authentication ticket obtained
    /// from Steam through the Steam SDK as the password.
    /// 
    /// 
    ///         * ps4 - use `platform:ps4` as the username and use the authorization code
    /// obtained from the PlayStation Network through a player PS4 unit as the password.
    /// 
    /// 
    ///         * live - use `platform:live` as the username and use token obtained from
    /// Xbox Secure Token Service (XSTS) as the password.
    /// 
    /// 
    ///         * oculus - use `platform:oculus` as the username and use the `user_id:nonce`
    /// as password obtained from Oculus through the Oculus SDK.
    /// 
    /// 
    /// 
    /// 
    /// The access token and refresh token are in form of JWT token.
    /// An access token JWT contains data which structure is similar to the
    /// Response Class below, but without OAuth-related data. To verify a token, use the public keys
    /// obtained from the `/jwks` endpoint below.
    /// 
    /// 
    /// 
    /// 
    /// ## Access Token Content
    /// 
    /// 
    /// 
    /// 
    /// Following is the access tokenâs content:
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// namespace. It is the namespace the token was generated from.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// display_name. The display name of the sub. It is empty if the token is generated from the client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// roles. The subâs roles. It is empty if the token is generated from the client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// namespace_roles. The subâs roles scoped to namespace. Improvement from roles, which make the role scoped to specific namespace instead of global to publisher namespace
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// permissions. The sub or audâ permissions
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// bans. The subâs list of bans. It is used by the IAM client for validating the token.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// jflgs. It stands for Justice Flags. It is a special flag used for storing additional status information regarding the sub. It is implemented as a bit mask. Following explains what each bit represents:
    /// 
    /// 
    /// 
    /// 
    ///           * 1: Email Address Verified
    /// 
    /// 
    /// 
    ///           * 2: Phone Number Verified
    /// 
    /// 
    /// 
    ///           * 4: Anonymous
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// aud. The aud is the client ID.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// iat. The time the token issues at. It is in Epoch time format
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// exp. The time the token expires. It is in Epoch time format
    /// 
    /// 
    /// 
    /// 
    /// 
    ///         *
    /// 
    /// 
    /// sub. The UserID. The sub is omitted if the token is generated from client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Bans
    /// 
    /// 
    /// 
    /// 
    /// The JWT contains user's active bans with its expiry date. List of ban types can be obtained from /bans.
    /// 
    /// 
    /// 
    /// 
    /// ## Track Login History
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will track login history to detect suspicious login activity, please provide "device_id" (alphanumeric) in request header parameter otherwise we will set to "unknown".
    /// 
    /// 
    /// 
    /// 
    /// Align with General Data Protection Regulation in Europe, user login history will be kept within 28 days by default"
    /// </summary>
    public class TokenGrant : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TokenGrantBuilder Builder = new TokenGrantBuilder();

        public class TokenGrantBuilder
            : OperationBuilder<TokenGrantBuilder>
        {
            public string? Code { get; set; }
            
            public bool? ExtendExp { get; set; }
            
            public string? Namespace { get; set; }
            
            public string? Password { get; set; }
            
            public string? RedirectUri { get; set; }
            
            public string? RefreshToken { get; set; }
            
            public string? Username { get; set; }
            
            
            internal TokenGrantBuilder() { }




            public TokenGrantBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public TokenGrantBuilder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }

            public TokenGrantBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public TokenGrantBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }

            public TokenGrantBuilder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }

            public TokenGrantBuilder SetRefreshToken(string _refreshToken)
            {
                RefreshToken = _refreshToken;
                return this;
            }

            public TokenGrantBuilder SetUsername(string _username)
            {
                Username = _username;
                return this;
            }



            public TokenGrant Build(
                string grantType
            )
            {
                TokenGrant op = new TokenGrant(this,
                    grantType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private TokenGrant(TokenGrantBuilder builder,
            string grantType
        )
        {
            
            
            if (builder.Code != null) FormParams["code"] = builder.Code;
            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (builder.Namespace != null) FormParams["namespace"] = builder.Namespace;
            if (builder.Password != null) FormParams["password"] = builder.Password;
            if (builder.RedirectUri != null) FormParams["redirect_uri"] = builder.RedirectUri;
            if (builder.RefreshToken != null) FormParams["refresh_token"] = builder.RefreshToken;
            if (builder.Username != null) FormParams["username"] = builder.Username;
            if (grantType != null) FormParams["grant_type"] = grantType;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TokenGrant(
            string? code,            
            bool? extendExp,            
            string? namespace_,            
            string? password,            
            string? redirectUri,            
            string? refreshToken,            
            string? username,            
            string grantType            
        )
        {
            
            
            if (code != null) FormParams["code"] = code;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (namespace_ != null) FormParams["namespace"] = namespace_;
            if (password != null) FormParams["password"] = password;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (refreshToken != null) FormParams["refresh_token"] = refreshToken;
            if (username != null) FormParams["username"] = username;
            if (grantType != null) FormParams["grant_type"] = grantType;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthmodelTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}