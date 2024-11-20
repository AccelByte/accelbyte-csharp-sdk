// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// UpdateAppV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [UPDATE]`
    /// 
    /// Update App Partially
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdateAppV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppV1Builder Builder { get => new UpdateAppV1Builder(); }

        public class UpdateAppV1Builder
            : OperationBuilder<UpdateAppV1Builder>
        {





            internal UpdateAppV1Builder() { }






            public UpdateAppV1 Build(
                GeneratedUpdateAppV1Request body,
                string app,
                string namespace_
            )
            {
                UpdateAppV1 op = new UpdateAppV1(this,
                    body,
                    app,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateAppV1(UpdateAppV1Builder builder,
            GeneratedUpdateAppV1Request body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAppV1(
            string app,
            string namespace_,
            Model.GeneratedUpdateAppV1Request body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GeneratedUpdateAppV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GeneratedUpdateAppV1Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GeneratedUpdateAppV1Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GeneratedUpdateAppV1Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}