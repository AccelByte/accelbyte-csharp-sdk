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
    /// PlatformAuthenticationV3
    ///
    /// This endpoint authenticates user platform. It validates user to its
    /// respective platforms. Deactivated or login-banned users are unable to login.
    /// 
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    ///                   * steamopenid
    /// Steam login page will redirects to this endpoint after login success
    /// as previously defined on openID request parameter `openid.return_to` when request login to steam
    /// https://openid.net/specs/openid-authentication-2_0.html#anchor27
    /// 
    ///                   * ps4web
    /// PS4 login page will redirects to this endpoint after login success
    /// as previously defined on authorize request parameter `redirect_uri`
    /// https://ps4.siedev.net/resources/documents/WebAPI/1/Auth_WebAPI-Reference/0002.html#0GetAccessTokenUsingAuthorizationCode
    /// 
    ///                   * xblweb
    /// XBL login page will redirects to this endpoint after login success
    /// as previously defined on authorize request parameter `redirect_uri`
    /// 
    ///                   * epicgames
    /// Epicgames login page will redirects to this endpoint after login success
    /// or an error occurred. If error, it redirects to the login page.
    /// 
    ///                   * twitch
    /// Twitch login page will redirects to this endpoint after login success
    /// as previously defined on authorize request parameter `redirect_uri`
    /// 
    ///                   * facebook
    /// Facebook login page will redirects to this endpoint after login success
    /// as previously defined on authorize request parameter `redirect_uri`
    /// 
    ///                   * google
    /// Google login page will redirects to this endpoint after login success
    /// as previously defined on authorize request parameter `redirect_uri`
    /// action code : 10709
    /// </summary>
    public class PlatformAuthenticationV3 : AccelByte.Sdk.Core.Operation
    {
        public PlatformAuthenticationV3(
            string platformId,            
            string? code,            
            string? error,            
            string? openidAssocHandle,            
            string? openidClaimedId,            
            string? openidIdentity,            
            string? openidMode,            
            string? openidNs,            
            string? openidOpEndpoint,            
            string? openidResponseNonce,            
            string? openidReturnTo,            
            string? openidSig,            
            string? openidSigned,            
            string state            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (code != null) QueryParams["code"] = code;
            if (error != null) QueryParams["error"] = error;
            if (openidAssocHandle != null) QueryParams["openid.assoc_handle"] = openidAssocHandle;
            if (openidClaimedId != null) QueryParams["openid.claimed_id"] = openidClaimedId;
            if (openidIdentity != null) QueryParams["openid.identity"] = openidIdentity;
            if (openidMode != null) QueryParams["openid.mode"] = openidMode;
            if (openidNs != null) QueryParams["openid.ns"] = openidNs;
            if (openidOpEndpoint != null) QueryParams["openid.op_endpoint"] = openidOpEndpoint;
            if (openidResponseNonce != null) QueryParams["openid.response_nonce"] = openidResponseNonce;
            if (openidReturnTo != null) QueryParams["openid.return_to"] = openidReturnTo;
            if (openidSig != null) QueryParams["openid.sig"] = openidSig;
            if (openidSigned != null) QueryParams["openid.signed"] = openidSigned;
            if (state != null) QueryParams["state"] = state;
            
            
            
            
            LocationQuery = "PLACEHOLDER";
        }

        public override string Path => "/iam/v3/platforms/{platformId}/authenticate";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "*/*" };

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