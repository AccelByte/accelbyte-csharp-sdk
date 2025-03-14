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
    /// UpdateThirdPartyLoginPlatformDomainV3
    ///
    /// This is the API to set 3rd Platform domain.
    /// This API is a create-or-update behavior. If it is update, it is a replacement behavior.
    /// </summary>
    public class UpdateThirdPartyLoginPlatformDomainV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateThirdPartyLoginPlatformDomainV3Builder Builder { get => new UpdateThirdPartyLoginPlatformDomainV3Builder(); }

        public class UpdateThirdPartyLoginPlatformDomainV3Builder
            : OperationBuilder<UpdateThirdPartyLoginPlatformDomainV3Builder>
        {





            internal UpdateThirdPartyLoginPlatformDomainV3Builder() { }






            public UpdateThirdPartyLoginPlatformDomainV3 Build(
                ModelPlatformDomainUpdateRequest body,
                string namespace_,
                string platformId
            )
            {
                UpdateThirdPartyLoginPlatformDomainV3 op = new UpdateThirdPartyLoginPlatformDomainV3(this,
                    body,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateThirdPartyLoginPlatformDomainV3(UpdateThirdPartyLoginPlatformDomainV3Builder builder,
            ModelPlatformDomainUpdateRequest body,
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

        public UpdateThirdPartyLoginPlatformDomainV3(
            string namespace_,
            string platformId,
            Model.ModelPlatformDomainUpdateRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients/domain";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelPlatformDomainResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelPlatformDomainResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelPlatformDomainResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPlatformDomainResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}