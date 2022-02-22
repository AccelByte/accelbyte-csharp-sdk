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
    /// PublicWebLinkPlatform
    ///
    /// This endpoint is used to generate third party login page which will redirected to establish endpoint.
    /// </summary>
    public class PublicWebLinkPlatform : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicWebLinkPlatformBuilder Builder = new PublicWebLinkPlatformBuilder();

        public class PublicWebLinkPlatformBuilder
        {
            
            
            public string? ClientId { get; set; }
            
            public string? RedirectUri { get; set; }
            
            internal PublicWebLinkPlatformBuilder() { }


            public PublicWebLinkPlatformBuilder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public PublicWebLinkPlatformBuilder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }




            public PublicWebLinkPlatform Build(
                string namespace_,
                string platformId
            )
            {
                return new PublicWebLinkPlatform(this,
                    namespace_,                    
                    platformId                    
                );
            }
        }

        private PublicWebLinkPlatform(PublicWebLinkPlatformBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            if (builder.ClientId != null) QueryParams["clientId"] = builder.ClientId;
            if (builder.RedirectUri != null) QueryParams["redirectUri"] = builder.RedirectUri;
            
            
            
            
        }
        #endregion

        public PublicWebLinkPlatform(
            string namespace_,            
            string platformId,            
            string? clientId,            
            string? redirectUri            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            if (clientId != null) QueryParams["clientId"] = clientId;
            if (redirectUri != null) QueryParams["redirectUri"] = redirectUri;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/web/link";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelWebLinkingResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelWebLinkingResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelWebLinkingResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}