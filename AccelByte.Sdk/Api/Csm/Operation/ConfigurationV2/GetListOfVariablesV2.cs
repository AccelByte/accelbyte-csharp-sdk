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
    /// GetListOfVariablesV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:VARIABLE [READ]`
    /// 
    /// Get list of environment variables per app
    /// Available Deployment Status:
    /// `deployed` = app config is already deployed
    /// `undeployed` = app config is not deployed yet and need restart and deploy of the app to be deployed
    /// </summary>
    public class GetListOfVariablesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListOfVariablesV2Builder Builder { get => new GetListOfVariablesV2Builder(); }

        public class GetListOfVariablesV2Builder
            : OperationBuilder<GetListOfVariablesV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetListOfVariablesV2Builder() { }


            public GetListOfVariablesV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetListOfVariablesV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetListOfVariablesV2 Build(
                string app,
                string namespace_
            )
            {
                GetListOfVariablesV2 op = new GetListOfVariablesV2(this,
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

        private GetListOfVariablesV2(GetListOfVariablesV2Builder builder,
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

        public GetListOfVariablesV2(
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

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/variables";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelGetListOfConfigurationsV2Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelGetListOfConfigurationsV2Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelGetListOfConfigurationsV2Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelGetListOfConfigurationsV2Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}