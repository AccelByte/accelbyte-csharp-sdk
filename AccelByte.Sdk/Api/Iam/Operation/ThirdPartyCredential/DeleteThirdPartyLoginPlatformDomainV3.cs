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
    /// DeleteThirdPartyLoginPlatformDomainV3
    ///
    /// 
    /// 
    /// This is the API to unregister 3rd Platform domain.
    /// 
    /// 
    /// 
    /// 
    /// It needs ADMIN:NAMESPACE:{namespace}:CLIENTDOMAIN [DELETE] resource.
    /// </summary>
    public class DeleteThirdPartyLoginPlatformDomainV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteThirdPartyLoginPlatformDomainV3Builder Builder = new DeleteThirdPartyLoginPlatformDomainV3Builder();

        public class DeleteThirdPartyLoginPlatformDomainV3Builder
        {
            
            
            
            internal DeleteThirdPartyLoginPlatformDomainV3Builder() { }





            public DeleteThirdPartyLoginPlatformDomainV3 Build(
                ModelPlatformDomainDeleteRequest body,
                string namespace_,
                string platformId
            )
            {
                return new DeleteThirdPartyLoginPlatformDomainV3(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );
            }
        }

        private DeleteThirdPartyLoginPlatformDomainV3(DeleteThirdPartyLoginPlatformDomainV3Builder builder,
            ModelPlatformDomainDeleteRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public DeleteThirdPartyLoginPlatformDomainV3(
            string namespace_,            
            string platformId,            
            Model.ModelPlatformDomainDeleteRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients/domain";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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