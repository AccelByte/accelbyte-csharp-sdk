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
    /// PublicPlatformLinkV2
    ///
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId} [POST]
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Prerequisite:
    /// Platform client configuration need to be added to database for specific platformId. Namespace service URL need to be specified (refer to required environment variables).
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * steam : The ticketâs value is the authentication code returned by Steam.
    /// 
    /// 
    ///   * steamopenid : Steam's user authentication method using OpenID 2.0. The ticket's value is URL generated by Steam on web authentication
    /// 
    /// 
    ///   * facebook : The ticketâs value is the authorization code returned by Facebook OAuth
    /// 
    /// 
    ///   * google : The ticketâs value is the authorization code returned by Google OAuth
    /// 
    /// 
    ///   * oculus : The ticketâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// 
    /// 
    ///   * twitch : The ticketâs value is the authorization code returned by Twitch OAuth.
    /// 
    /// 
    ///   * android : The ticket's value is the Androidâs device ID
    /// 
    /// 
    ///   * ios : The ticket's value is the iOSâs device ID.
    /// 
    /// 
    ///   * device : Every device that doesn't run Android and iOS is categorized as a device platform. The ticket's value is the deviceâs ID.
    /// 
    /// 
    ///   * discord : The ticketâs value is the authorization code returned by Discord OAuth.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicPlatformLinkV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlatformLinkV2Builder Builder = new PublicPlatformLinkV2Builder();

        public class PublicPlatformLinkV2Builder
            : OperationBuilder<PublicPlatformLinkV2Builder>
        {





            internal PublicPlatformLinkV2Builder() { }






            public PublicPlatformLinkV2 Build(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                PublicPlatformLinkV2 op = new PublicPlatformLinkV2(this,
                    ticket,                    
                    namespace_,                    
                    platformId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPlatformLinkV2(PublicPlatformLinkV2Builder builder,
            string ticket,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            if (ticket is not null) FormParams["ticket"] = ticket;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPlatformLinkV2(
            string namespace_,            
            string platformId,            
            string userId,            
            string ticket            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            if (ticket is not null) FormParams["ticket"] = ticket;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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