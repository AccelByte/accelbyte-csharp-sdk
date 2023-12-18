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
    /// UpdateSSOPlatformCredential
    ///
    /// This is the API to Delete SSO Platform Credential.
    /// </summary>
    public class UpdateSSOPlatformCredential : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSSOPlatformCredentialBuilder Builder { get => new UpdateSSOPlatformCredentialBuilder(); }

        public class UpdateSSOPlatformCredentialBuilder
            : OperationBuilder<UpdateSSOPlatformCredentialBuilder>
        {





            internal UpdateSSOPlatformCredentialBuilder() { }






            public UpdateSSOPlatformCredential Build(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                UpdateSSOPlatformCredential op = new UpdateSSOPlatformCredential(this,
                    body,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private UpdateSSOPlatformCredential(UpdateSSOPlatformCredentialBuilder builder,
            ModelSSOPlatformCredentialRequest body,
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

        public UpdateSSOPlatformCredential(
            string namespace_,
            string platformId,
            Model.ModelSSOPlatformCredentialRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

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