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
    /// UpdateThirdPartyLoginPlatformCredentialV3
    ///
    /// 
    /// 
    /// This is the API to Add 3rd Platform Credential.
    /// 
    /// 
    /// 
    /// 
    /// It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:CLIENT [CREATE] resource.
    /// 
    /// 
    /// 
    /// 
    /// The secret for apple is base64 encoded private key.
    /// </summary>
    public class UpdateThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateThirdPartyLoginPlatformCredentialV3Builder Builder = new UpdateThirdPartyLoginPlatformCredentialV3Builder();

        public class UpdateThirdPartyLoginPlatformCredentialV3Builder
        {
            
            
            
            internal UpdateThirdPartyLoginPlatformCredentialV3Builder() { }





            public UpdateThirdPartyLoginPlatformCredentialV3 Build(
                ModelThirdPartyLoginPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                return new UpdateThirdPartyLoginPlatformCredentialV3(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );
            }
        }

        private UpdateThirdPartyLoginPlatformCredentialV3(UpdateThirdPartyLoginPlatformCredentialV3Builder builder,
            ModelThirdPartyLoginPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateThirdPartyLoginPlatformCredentialV3(
            string namespace_,            
            string platformId,            
            Model.ModelThirdPartyLoginPlatformCredentialRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelThirdPartyLoginPlatformCredentialResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelThirdPartyLoginPlatformCredentialResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}