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
    /// PublicForceLinkPlatformWithProgression
    ///
    /// Force update other account's Platform Account relation to current User Account.
    /// 
    /// This endpoint can transfer progression from 3rd platform binding account's to current account.
    /// This endpoint need the same requestID which also used in Get link status.
    /// </summary>
    public class PublicForceLinkPlatformWithProgression : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForceLinkPlatformWithProgressionBuilder Builder = new PublicForceLinkPlatformWithProgressionBuilder();

        public class PublicForceLinkPlatformWithProgressionBuilder
            : OperationBuilder<PublicForceLinkPlatformWithProgressionBuilder>
        {





            internal PublicForceLinkPlatformWithProgressionBuilder() { }






            public PublicForceLinkPlatformWithProgression Build(
                ModelLinkPlatformAccountWithProgressionRequest body,
                string namespace_,
                string userId
            )
            {
                PublicForceLinkPlatformWithProgression op = new PublicForceLinkPlatformWithProgression(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicForceLinkPlatformWithProgression(PublicForceLinkPlatformWithProgressionBuilder builder,
            ModelLinkPlatformAccountWithProgressionRequest body,
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

        public PublicForceLinkPlatformWithProgression(
            string namespace_,            
            string userId,            
            Model.ModelLinkPlatformAccountWithProgressionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/linkWithProgression";

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