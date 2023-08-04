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
    /// RetrieveSSOLoginPlatformCredential
    ///
    /// This is the API to Get SSO Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:SSO [READ] resource
    /// </summary>
    public class RetrieveSSOLoginPlatformCredential : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSSOLoginPlatformCredentialBuilder Builder { get => new RetrieveSSOLoginPlatformCredentialBuilder(); }

        public class RetrieveSSOLoginPlatformCredentialBuilder
            : OperationBuilder<RetrieveSSOLoginPlatformCredentialBuilder>
        {





            internal RetrieveSSOLoginPlatformCredentialBuilder() { }






            public RetrieveSSOLoginPlatformCredential Build(
                string namespace_,
                string platformId
            )
            {
                RetrieveSSOLoginPlatformCredential op = new RetrieveSSOLoginPlatformCredential(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private RetrieveSSOLoginPlatformCredential(RetrieveSSOLoginPlatformCredentialBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public RetrieveSSOLoginPlatformCredential(
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public Model.ModelSSOPlatformCredentialResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}