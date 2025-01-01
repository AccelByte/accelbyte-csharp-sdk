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
    /// GetAppImageListV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:IMAGE [READ]`
    /// 
    /// Get a list of container images
    /// 
    /// Default 'cached' parameter is 'true'
    /// </summary>
    public class GetAppImageListV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAppImageListV2Builder Builder { get => new GetAppImageListV2Builder(); }

        public class GetAppImageListV2Builder
            : OperationBuilder<GetAppImageListV2Builder>
        {

            public string? Cached { get; set; }





            internal GetAppImageListV2Builder() { }


            public GetAppImageListV2Builder SetCached(string _cached)
            {
                Cached = _cached;
                return this;
            }





            public GetAppImageListV2 Build(
                string app,
                string namespace_
            )
            {
                GetAppImageListV2 op = new GetAppImageListV2(this,
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

        private GetAppImageListV2(GetAppImageListV2Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;

            if (builder.Cached is not null) QueryParams["cached"] = builder.Cached;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAppImageListV2(
            string app,
            string namespace_,
            string? cached
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;

            if (cached is not null) QueryParams["cached"] = cached;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/images";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelGetAppImageListV2Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelGetAppImageListV2Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelGetAppImageListV2Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelGetAppImageListV2Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}