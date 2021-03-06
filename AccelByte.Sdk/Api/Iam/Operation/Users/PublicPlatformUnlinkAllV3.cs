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
    /// PublicPlatformUnlinkAllV3
    ///
    /// Required valid user authorization.
    /// 
    /// 
    /// Unlink user's account from for all third platforms.
    /// </summary>
    public class PublicPlatformUnlinkAllV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlatformUnlinkAllV3Builder Builder = new PublicPlatformUnlinkAllV3Builder();

        public class PublicPlatformUnlinkAllV3Builder
            : OperationBuilder<PublicPlatformUnlinkAllV3Builder>
        {





            internal PublicPlatformUnlinkAllV3Builder() { }






            public PublicPlatformUnlinkAllV3 Build(
                string namespace_,
                string platformId
            )
            {
                PublicPlatformUnlinkAllV3 op = new PublicPlatformUnlinkAllV3(this,
                    namespace_,                    
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPlatformUnlinkAllV3(PublicPlatformUnlinkAllV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPlatformUnlinkAllV3(
            string namespace_,            
            string platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/all";

        public override HttpMethod Method => HttpMethod.Delete;

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