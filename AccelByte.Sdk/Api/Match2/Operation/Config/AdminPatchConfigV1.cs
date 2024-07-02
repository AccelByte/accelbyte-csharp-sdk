// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// adminPatchConfigV1
    ///
    /// Patch update matchmaking config of a namespaces. Partially update matchmaking config, will only update value that defined on the request.
    /// </summary>
    public class AdminPatchConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPatchConfigV1Builder Builder { get => new AdminPatchConfigV1Builder(); }

        public class AdminPatchConfigV1Builder
            : OperationBuilder<AdminPatchConfigV1Builder>
        {





            internal AdminPatchConfigV1Builder() { }






            public AdminPatchConfigV1 Build(
                ApiPatchNamespaceConfigRequest body,
                string namespace_
            )
            {
                AdminPatchConfigV1 op = new AdminPatchConfigV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminPatchConfigV1(AdminPatchConfigV1Builder builder,
            ApiPatchNamespaceConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPatchConfigV1(
            string namespace_,
            Model.ApiPatchNamespaceConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ConfigmodelsNamespaceConfig? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ConfigmodelsNamespaceConfig>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ConfigmodelsNamespaceConfig>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConfigmodelsNamespaceConfig>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}