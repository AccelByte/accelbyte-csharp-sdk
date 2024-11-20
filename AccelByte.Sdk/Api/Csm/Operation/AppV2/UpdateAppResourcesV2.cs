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
    /// UpdateAppResourcesV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [UPDATE]`
    /// 
    /// Update app resources provided on request body
    /// </summary>
    public class UpdateAppResourcesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppResourcesV2Builder Builder { get => new UpdateAppResourcesV2Builder(); }

        public class UpdateAppResourcesV2Builder
            : OperationBuilder<UpdateAppResourcesV2Builder>
        {





            internal UpdateAppResourcesV2Builder() { }






            public UpdateAppResourcesV2 Build(
                ApimodelUpdateAppResourceRequest body,
                string app,
                string namespace_
            )
            {
                UpdateAppResourcesV2 op = new UpdateAppResourcesV2(this,
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

        private UpdateAppResourcesV2(UpdateAppResourcesV2Builder builder,
            ApimodelUpdateAppResourceRequest body,
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

        public UpdateAppResourcesV2(
            string app,
            string namespace_,
            Model.ApimodelUpdateAppResourceRequest body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelAppItem? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelAppItem>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelAppItem>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelAppItem>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}