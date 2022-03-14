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
    /// TokenGrantV3
    ///
    /// 
    /// 
    /// This endpoint supports grant type:
    /// 
    /// 
    /// 
    ///                   1. Grant Type == `authorization_code`:
    /// 
    ///     It generates the user token by given the authorization
    /// code which generated in "/v3/oauth/auth" API response. It should also pass
    /// in the redirect_uri, which should be the same as generating the
    /// authorization code request.
    /// 
    /// 
    /// 
    ///                   2. Grant Type == `password`:
    /// 
    ///     The grant type to use for authenticating a user, whether it's by email / username and password combination
    /// or through platform.
    /// 
    /// 
    /// 
    ///                   3. Grant Type == `refresh_token`:
    /// 
    ///     Used to get a new access token for a valid refresh token.
    /// 
    /// 
    /// 
    ///                   4. Grant Type == `client_credentials`:
    /// 
    ///     It generates a token by checking the client credentials provided through Authorization header.
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
    ///                   *
    /// 
    /// 
    /// namespace. It is the namespace the token was generated from.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// display_name. The display name of the sub. It is empty if the token is generated from the client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// roles. The subâs roles. It is empty if the token is generated from the client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// namespace_roles. The subâs roles scoped to namespace. Improvement from roles, which make the role scoped to specific namespace instead of global to publisher namespace
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// permissions. The sub or audâ permissions
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// bans. The subâs list of bans. It is used by the IAM client for validating the token.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// jflgs. It stands for Justice Flags. It is a special flag used for storing additional status information regarding the sub. It is implemented as a bit mask. Following explains what each bit represents:
    /// 
    /// 
    /// 
    /// 
    ///                     * 1: Email Address Verified
    /// 
    /// 
    /// 
    ///                     * 2: Phone Number Verified
    /// 
    /// 
    /// 
    ///                     * 4: Anonymous
    /// 
    /// 
    /// 
    ///                     * 8: Suspicious Login
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// aud. The aud is the targeted resource server.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// iat. The time the token issues at. It is in Epoch time format
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// exp. The time the token expires. It is in Epoch time format
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// client_id. The UserID. The sub is omitted if the token is generated from client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                   *
    /// 
    /// 
    /// scope. The scope of the access request, expressed as a list of space-delimited, case-sensitive strings
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
    /// 
    /// 
    /// 
    /// 
    /// action code: 10703
    /// </summary>
    public class TokenGrantV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TokenGrantV3Builder Builder = new TokenGrantV3Builder();

        public class TokenGrantV3Builder
        {
            public string? ClientId { get; set; }
            
            public string? Code { get; set; }
            
            public string? CodeVerifier { get; set; }
            
            public bool? ExtendExp { get; set; }
            
            public string? Password { get; set; }
            
            public string? RedirectUri { get; set; }
            
            public string? RefreshToken { get; set; }
            
            public string? Username { get; set; }
            
            
            internal TokenGrantV3Builder() { }




            public TokenGrantV3Builder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public TokenGrantV3Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public TokenGrantV3Builder SetCodeVerifier(string _codeVerifier)
            {
                CodeVerifier = _codeVerifier;
                return this;
            }

            public TokenGrantV3Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }

            public TokenGrantV3Builder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }

            public TokenGrantV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }

            public TokenGrantV3Builder SetRefreshToken(string _refreshToken)
            {
                RefreshToken = _refreshToken;
                return this;
            }

            public TokenGrantV3Builder SetUsername(string _username)
            {
                Username = _username;
                return this;
            }


            public TokenGrantV3 Build(
                string grantType
            )
            {
                return new TokenGrantV3(this,
                    grantType                    
                );
            }
        }

        private TokenGrantV3(TokenGrantV3Builder builder,
            string grantType
        )
        {
            
            
            if (builder.ClientId != null) FormParams["client_id"] = builder.ClientId;
            if (builder.Code != null) FormParams["code"] = builder.Code;
            if (builder.CodeVerifier != null) FormParams["code_verifier"] = builder.CodeVerifier;
            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (builder.Password != null) FormParams["password"] = builder.Password;
            if (builder.RedirectUri != null) FormParams["redirect_uri"] = builder.RedirectUri;
            if (builder.RefreshToken != null) FormParams["refresh_token"] = builder.RefreshToken;
            if (builder.Username != null) FormParams["username"] = builder.Username;
            if (grantType != null) FormParams["grant_type"] = grantType;
            
            
            
        }
        #endregion

        public TokenGrantV3(
            string? clientId,            
            string? code,            
            string? codeVerifier,            
            bool? extendExp,            
            string? password,            
            string? redirectUri,            
            string? refreshToken,            
            string? username,            
            string grantType            
        )
        {
            
            
            if (clientId != null) FormParams["client_id"] = clientId;
            if (code != null) FormParams["code"] = code;
            if (codeVerifier != null) FormParams["code_verifier"] = codeVerifier;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (password != null) FormParams["password"] = password;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (refreshToken != null) FormParams["refresh_token"] = refreshToken;
            if (username != null) FormParams["username"] = username;
            if (grantType != null) FormParams["grant_type"] = grantType;
            
            
            
        }

        public override string Path => "/iam/v3/oauth/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security { get; set; } = "Basic";
        
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