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
        #region Builder Part
        public static PlatformAuthenticationV3Builder Builder = new PlatformAuthenticationV3Builder();

        public class PlatformAuthenticationV3Builder
        {
            
            public string? Code { get; set; }
            
            public string? Error { get; set; }
            
            public string? OpenidAssocHandle { get; set; }
            
            public string? OpenidClaimedId { get; set; }
            
            public string? OpenidIdentity { get; set; }
            
            public string? OpenidMode { get; set; }
            
            public string? OpenidNs { get; set; }
            
            public string? OpenidOpEndpoint { get; set; }
            
            public string? OpenidResponseNonce { get; set; }
            
            public string? OpenidReturnTo { get; set; }
            
            public string? OpenidSig { get; set; }
            
            public string? OpenidSigned { get; set; }
            
            
            internal PlatformAuthenticationV3Builder() { }


            public PlatformAuthenticationV3Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public PlatformAuthenticationV3Builder SetError(string _error)
            {
                Error = _error;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidAssocHandle(string _openidAssocHandle)
            {
                OpenidAssocHandle = _openidAssocHandle;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidClaimedId(string _openidClaimedId)
            {
                OpenidClaimedId = _openidClaimedId;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidIdentity(string _openidIdentity)
            {
                OpenidIdentity = _openidIdentity;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidMode(string _openidMode)
            {
                OpenidMode = _openidMode;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidNs(string _openidNs)
            {
                OpenidNs = _openidNs;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidOpEndpoint(string _openidOpEndpoint)
            {
                OpenidOpEndpoint = _openidOpEndpoint;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidResponseNonce(string _openidResponseNonce)
            {
                OpenidResponseNonce = _openidResponseNonce;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidReturnTo(string _openidReturnTo)
            {
                OpenidReturnTo = _openidReturnTo;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidSig(string _openidSig)
            {
                OpenidSig = _openidSig;
                return this;
            }

            public PlatformAuthenticationV3Builder SetOpenidSigned(string _openidSigned)
            {
                OpenidSigned = _openidSigned;
                return this;
            }




            public PlatformAuthenticationV3 Build(
                string platformId,
                string state
            )
            {
                return new PlatformAuthenticationV3(this,
                    platformId,                    
                    state                    
                );
            }
        }

        private PlatformAuthenticationV3(PlatformAuthenticationV3Builder builder,
            string platformId,
            string state
        )
        {
            PathParams["platformId"] = platformId;
            
            if (builder.Code != null) QueryParams["code"] = builder.Code;
            if (builder.Error != null) QueryParams["error"] = builder.Error;
            if (builder.OpenidAssocHandle != null) QueryParams["openid.assoc_handle"] = builder.OpenidAssocHandle;
            if (builder.OpenidClaimedId != null) QueryParams["openid.claimed_id"] = builder.OpenidClaimedId;
            if (builder.OpenidIdentity != null) QueryParams["openid.identity"] = builder.OpenidIdentity;
            if (builder.OpenidMode != null) QueryParams["openid.mode"] = builder.OpenidMode;
            if (builder.OpenidNs != null) QueryParams["openid.ns"] = builder.OpenidNs;
            if (builder.OpenidOpEndpoint != null) QueryParams["openid.op_endpoint"] = builder.OpenidOpEndpoint;
            if (builder.OpenidResponseNonce != null) QueryParams["openid.response_nonce"] = builder.OpenidResponseNonce;
            if (builder.OpenidReturnTo != null) QueryParams["openid.return_to"] = builder.OpenidReturnTo;
            if (builder.OpenidSig != null) QueryParams["openid.sig"] = builder.OpenidSig;
            if (builder.OpenidSigned != null) QueryParams["openid.signed"] = builder.OpenidSigned;
            if (state != null) QueryParams["state"] = state;
            
            
            
            
            LocationQuery = "PLACEHOLDER";
        }
        #endregion

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