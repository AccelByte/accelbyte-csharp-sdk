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
    /// DeleteThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Delete 3rd Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:CLIENT [DELETE] resource
    /// </summary>
    public class DeleteThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteThirdPartyLoginPlatformCredentialV3Builder Builder = new DeleteThirdPartyLoginPlatformCredentialV3Builder();

        public class DeleteThirdPartyLoginPlatformCredentialV3Builder
            : OperationBuilder<DeleteThirdPartyLoginPlatformCredentialV3Builder>
        {
            
            
            internal DeleteThirdPartyLoginPlatformCredentialV3Builder() { }






            public DeleteThirdPartyLoginPlatformCredentialV3 Build(
                string namespace_,
                string platformId
            )
            {
                DeleteThirdPartyLoginPlatformCredentialV3 op = new DeleteThirdPartyLoginPlatformCredentialV3(this,
                    namespace_,                    
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteThirdPartyLoginPlatformCredentialV3(DeleteThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteThirdPartyLoginPlatformCredentialV3(
            string namespace_,            
            string platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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