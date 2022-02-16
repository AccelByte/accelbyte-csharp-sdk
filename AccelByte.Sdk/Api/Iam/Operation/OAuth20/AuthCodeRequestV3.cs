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
    /// AuthCodeRequestV3
    ///
    /// Generate url to request auth code from third party platform
    /// 
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    ///                 * steamopenid
    /// This endpoint redirects to steam login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating user steam.
    /// 
    ///                 * xblweb
    /// This endpoint redirects to xbox login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating xbox user.
    /// 
    ///                 * ps4web
    /// This endpoint redirects to psn login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating psn user.
    /// 
    ///                 * epicgames
    /// This endpoint redirects to Epicgames OAuth login page. then redirect to platform
    /// authenticate endpoint after successfully authenticating an Epicgames credential
    /// 
    ///                 * twitch
    /// This endpoint redirects to twitch login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating twitch user.
    /// 
    ///                 * azure
    /// This endpoint redirects to azure login page, then redirect back to platform
    /// authenticate(saml) endpoint after successfully authenticating azure user.
    /// 
    ///                 * facebook
    /// This endpoint redirects to facebook login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating facebook user.
    /// 
    ///                 * google
    /// This endpoint redirects to google login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating google user.
    /// action code : 10702'
    /// </summary>
    public class AuthCodeRequestV3 : AccelByte.Sdk.Core.Operation
    {
        public AuthCodeRequestV3(
            string platformId,            
            string? clientId,            
            string? redirectUri,            
            string requestId            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (clientId != null) QueryParams["client_id"] = clientId;
            if (redirectUri != null) QueryParams["redirect_uri"] = redirectUri;
            if (requestId != null) QueryParams["request_id"] = requestId;
            
            
            
            
            LocationQuery = "code";
        }

        public override string Path => "/iam/v3/oauth/platforms/{platformId}/authorize";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

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