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
    /// PublicDeletePlatformLinkV2
    ///
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    /// 
    ///           * steam
    /// 
    /// 
    ///           * steamopenid
    /// 
    /// 
    ///           * facebook
    /// 
    /// 
    ///           * google
    /// 
    /// 
    ///           * oculus
    /// 
    /// 
    ///           * twitch
    /// 
    /// 
    ///           * android
    /// 
    /// 
    ///           * ios
    /// 
    /// 
    ///           * device
    /// 
    /// 
    ///           * discord
    /// 
    /// 
    /// 
    /// 
    /// Delete link of user's account with platform. 'justice' platform might have multiple accounts from different namespaces linked. platform_namespace need to be specified when the platform ID is 'justice'.
    /// 
    /// Delete link of justice platform will enable password token grant and password update.
    /// </summary>
    public class PublicDeletePlatformLinkV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePlatformLinkV2Builder Builder = new PublicDeletePlatformLinkV2Builder();

        public class PublicDeletePlatformLinkV2Builder
        {
            
            
            
            public string? PlatformNamespace { get; set; }
            
            internal PublicDeletePlatformLinkV2Builder() { }




            public PublicDeletePlatformLinkV2Builder SetPlatformNamespace(string _platformNamespace)
            {
                PlatformNamespace = _platformNamespace;
                return this;
            }


            public PublicDeletePlatformLinkV2 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                return new PublicDeletePlatformLinkV2(this,
                    namespace_,                    
                    platformId,                    
                    userId                    
                );
            }
        }

        private PublicDeletePlatformLinkV2(PublicDeletePlatformLinkV2Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            if (builder.PlatformNamespace != null) FormParams["platform_namespace"] = builder.PlatformNamespace;
            
            
            
        }
        #endregion

        public PublicDeletePlatformLinkV2(
            string namespace_,            
            string platformId,            
            string userId,            
            string? platformNamespace            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            if (platformNamespace != null) FormParams["platform_namespace"] = platformNamespace;
            
            
            
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded","text/plain" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}