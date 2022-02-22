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
    /// RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
    ///
    /// This is the Public API to Get All Active 3rd Platform Credential.
    /// </summary>
    public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder Builder = new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder();

        public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder
        {
            
            internal RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder() { }





            public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 Build(
                string namespace_
            )
            {
                return new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(this,
                    namespace_                    
                );
            }
        }

        private RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/clients/active";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelPublicThirdPartyPlatformInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}