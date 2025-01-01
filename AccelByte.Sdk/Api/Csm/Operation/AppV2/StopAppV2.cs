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
    /// StopAppV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [UPDATE]`
    /// 
    /// Stops the Application
    /// </summary>
    public class StopAppV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static StopAppV2Builder Builder { get => new StopAppV2Builder(); }

        public class StopAppV2Builder
            : OperationBuilder<StopAppV2Builder>
        {





            internal StopAppV2Builder() { }






            public StopAppV2 Build(
                string app,
                string namespace_
            )
            {
                StopAppV2 op = new StopAppV2(this,
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

        private StopAppV2(StopAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public StopAppV2(
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/stop";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}