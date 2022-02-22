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
    /// RetrieveAllThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Get All Active 3rd Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:*:CLIENT [READ] resource
    /// </summary>
    public class RetrieveAllThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllThirdPartyLoginPlatformCredentialV3Builder Builder = new RetrieveAllThirdPartyLoginPlatformCredentialV3Builder();

        public class RetrieveAllThirdPartyLoginPlatformCredentialV3Builder
        {
            
            internal RetrieveAllThirdPartyLoginPlatformCredentialV3Builder() { }





            public RetrieveAllThirdPartyLoginPlatformCredentialV3 Build(
                string namespace_
            )
            {
                return new RetrieveAllThirdPartyLoginPlatformCredentialV3(this,
                    namespace_                    
                );
            }
        }

        private RetrieveAllThirdPartyLoginPlatformCredentialV3(RetrieveAllThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public RetrieveAllThirdPartyLoginPlatformCredentialV3(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/all/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}