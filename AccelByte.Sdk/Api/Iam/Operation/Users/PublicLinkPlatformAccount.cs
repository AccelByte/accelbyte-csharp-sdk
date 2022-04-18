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
    /// PublicLinkPlatformAccount
    ///
    /// Update Platform Account relation to current User Account.
    /// Note: Game progression data (statistics, reward, etc) associated with previous User Account will not be
    /// transferred. If the data is tight to game user ID, the user will have the game progression data.
    /// </summary>
    public class PublicLinkPlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicLinkPlatformAccountBuilder Builder = new PublicLinkPlatformAccountBuilder();

        public class PublicLinkPlatformAccountBuilder
            : OperationBuilder<PublicLinkPlatformAccountBuilder>
        {
            
            
            
            internal PublicLinkPlatformAccountBuilder() { }





            public PublicLinkPlatformAccount Build(
                ModelLinkPlatformAccountRequest body,
                string namespace_,
                string userId
            )
            {
                PublicLinkPlatformAccount op = new PublicLinkPlatformAccount(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicLinkPlatformAccount(PublicLinkPlatformAccountBuilder builder,
            ModelLinkPlatformAccountRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicLinkPlatformAccount(
            string namespace_,            
            string userId,            
            Model.ModelLinkPlatformAccountRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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