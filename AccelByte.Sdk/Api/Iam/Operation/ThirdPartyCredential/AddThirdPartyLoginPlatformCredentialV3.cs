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
    /// AddThirdPartyLoginPlatformCredentialV3
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
    /// 
    /// 
    /// 
    /// 
    /// If generic oauth flow is set to true:
    /// 
    /// 
    /// 
    /// 
    ///           * Current supported value for TokenAuthenticationType is idToken
    /// 
    /// 
    ///           * `TokenClaimsMapping` is used to extract user info from idToken claims.
    /// Its a JSON format with key should be `name`, `email` and `avatarUrl`
    /// since IAM will look up for these key when extracting user info.
    /// </summary>
    public class AddThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddThirdPartyLoginPlatformCredentialV3Builder Builder = new AddThirdPartyLoginPlatformCredentialV3Builder();

        public class AddThirdPartyLoginPlatformCredentialV3Builder
            : OperationBuilder<AddThirdPartyLoginPlatformCredentialV3Builder>
        {
            
            
            
            internal AddThirdPartyLoginPlatformCredentialV3Builder() { }





            public AddThirdPartyLoginPlatformCredentialV3 Build(
                ModelThirdPartyLoginPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                AddThirdPartyLoginPlatformCredentialV3 op = new AddThirdPartyLoginPlatformCredentialV3(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AddThirdPartyLoginPlatformCredentialV3(AddThirdPartyLoginPlatformCredentialV3Builder builder,
            ModelThirdPartyLoginPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddThirdPartyLoginPlatformCredentialV3(
            string namespace_,            
            string platformId,            
            Model.ModelThirdPartyLoginPlatformCredentialRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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