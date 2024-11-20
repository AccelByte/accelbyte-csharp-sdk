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
    /// GetListOfSecretsV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:SECRET [READ]`
    /// 
    /// Get list of environment secrets per app
    /// Available Deployment Status:
    /// `deployed` = app config is already deployed
    /// `undeployed` = app config is not deployed yet and need restart and deploy of the app to be deployed
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetListOfSecretsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListOfSecretsV1Builder Builder { get => new GetListOfSecretsV1Builder(); }

        public class GetListOfSecretsV1Builder
            : OperationBuilder<GetListOfSecretsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetListOfSecretsV1Builder() { }


            public GetListOfSecretsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetListOfSecretsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetListOfSecretsV1 Build(
                string app,
                string namespace_
            )
            {
                GetListOfSecretsV1 op = new GetListOfSecretsV1(this,
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

        private GetListOfSecretsV1(GetListOfSecretsV1Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetListOfSecretsV1(
            string app,
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GeneratedGetListOfConfigurationsV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GeneratedGetListOfConfigurationsV1Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GeneratedGetListOfConfigurationsV1Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GeneratedGetListOfConfigurationsV1Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}