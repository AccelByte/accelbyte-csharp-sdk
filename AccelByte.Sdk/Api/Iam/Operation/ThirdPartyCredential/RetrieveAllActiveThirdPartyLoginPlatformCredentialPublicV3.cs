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
    /// RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
    ///
    /// This is the Public API to Get All Active 3rd Platform Credential.
    /// </summary>
    public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder Builder { get => new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder(); }

        public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder
            : OperationBuilder<RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder>
        {





            internal RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder() { }






            public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 Build(
                string namespace_
            )
            {
                RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 op = new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/clients/active";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelPublicThirdPartyPlatformInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}