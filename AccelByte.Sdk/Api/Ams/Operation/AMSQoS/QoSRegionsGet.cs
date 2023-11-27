// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// QoSRegionsGet
    ///
    /// Required Permission: NAMESPACE:{namespace}:QOS:SERVER [READ]
    /// </summary>
    public class QoSRegionsGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QoSRegionsGetBuilder Builder { get => new QoSRegionsGetBuilder(); }

        public class QoSRegionsGetBuilder
            : OperationBuilder<QoSRegionsGetBuilder>
        {

            public string? Status { get; set; }





            internal QoSRegionsGetBuilder() { }


            public QoSRegionsGetBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public QoSRegionsGet Build(
                string namespace_
            )
            {
                QoSRegionsGet op = new QoSRegionsGet(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private QoSRegionsGet(QoSRegionsGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QoSRegionsGet(
            string namespace_,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/namespaces/{namespace}/qos";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiQoSEndpointResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiQoSEndpointResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiQoSEndpointResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiQoSEndpointResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}