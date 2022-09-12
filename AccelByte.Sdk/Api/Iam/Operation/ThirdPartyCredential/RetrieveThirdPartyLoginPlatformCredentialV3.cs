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
    /// RetrieveThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Get 3rd Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:CLIENT [READ] resource
    /// </summary>
    public class RetrieveThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveThirdPartyLoginPlatformCredentialV3Builder Builder = new RetrieveThirdPartyLoginPlatformCredentialV3Builder();

        public class RetrieveThirdPartyLoginPlatformCredentialV3Builder
            : OperationBuilder<RetrieveThirdPartyLoginPlatformCredentialV3Builder>
        {





            internal RetrieveThirdPartyLoginPlatformCredentialV3Builder() { }






            public RetrieveThirdPartyLoginPlatformCredentialV3 Build(
                string namespace_,
                string platformId
            )
            {
                RetrieveThirdPartyLoginPlatformCredentialV3 op = new RetrieveThirdPartyLoginPlatformCredentialV3(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveThirdPartyLoginPlatformCredentialV3(RetrieveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveThirdPartyLoginPlatformCredentialV3(
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

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