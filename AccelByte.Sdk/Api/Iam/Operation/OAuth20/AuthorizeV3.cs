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
    /// AuthorizeV3
    ///
    /// Initializes OAuth2.0 authorization code flow
    /// 
    /// 
    /// 
    /// The endpoint stores authorization request and redirects to login page with the authorization request id.
    /// The user can then do the authentication on the login page.
    /// The user will be redirected back to the requesting client with authorization code if successfully authenticated.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Only authorization code flow supported by this endpoint, implicit flow is not supported.
    /// 
    /// 
    /// 
    /// 
    ///                 * Authorize success :
    /// redirects to login page with the following information: ?request_id={authorization_request_id}
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 * Authorize failure :
    /// redirects to the given redirect uri with the following information:
    /// ?error={error_code}&error;_description={error description}
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Following are the error code based on the specification:
    /// 
    /// 
    /// 
    /// 
    ///                 * invalid_request: The request is missing a required parameter,
    /// includes an invalid parameter value, includes a parameter more than once, or is otherwise malformed.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 * server_error:
    /// The authorization server encountered an unexpected condition that prevented it from fulfilling the request.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 * unauthorized_client: The client is not authorized to request a token using this method.
    /// 
    /// 
    /// 
    ///                 * access_denied: The resource owner or authorization server denied the request.
    /// 
    /// 
    /// 
    ///                 * invalid_scope: The requested scope is invalid, unknown, or malformed.
    /// 
    /// 
    /// 
    ///                 * unsupported_response_type: The authorization server does not support obtaining a token using this method.
    /// 
    /// 
    /// 
    ///                 * temporarily_unavailable: The authorization server is currently unable to handle the request
    /// due to a temporary overloading or maintenance of the server.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Please refer to the RFC for more information about authorization code flow: https://tools.ietf.org/html/rfc6749#section-4.1
    /// 
    /// 
    /// 
    /// action code: 10701
    /// </summary>
    public class AuthorizeV3 : AccelByte.Sdk.Core.Operation
    {
        public AuthorizeV3(
            string? codeChallenge,            
            string? codeChallengeMethod,            
            string? redirectUri,            
            string? scope,            
            string? state,            
            string? targetAuthPage,            
            string clientId,            
            string responseType            
        )
        {
            
            if (codeChallenge != null) QueryParams["code_challenge"] = codeChallenge;
            if (codeChallengeMethod != null) QueryParams["code_challenge_method"] = codeChallengeMethod;
            if (redirectUri != null) QueryParams["redirect_uri"] = redirectUri;
            if (scope != null) QueryParams["scope"] = scope;
            if (state != null) QueryParams["state"] = state;
            if (targetAuthPage != null) QueryParams["target_auth_page"] = targetAuthPage;
            if (clientId != null) QueryParams["client_id"] = clientId;
            if (responseType != null) QueryParams["response_type"] = responseType;
            
            
            
            
            LocationQuery = "request_id";
        }

        public override string Path => "/iam/v3/oauth/authorize";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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