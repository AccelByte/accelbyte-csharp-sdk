// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetAllPodConfigClient
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a all pod configs in a namespace
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class GetAllPodConfigClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllPodConfigClientBuilder Builder { get => new GetAllPodConfigClientBuilder(); }

        public class GetAllPodConfigClientBuilder
            : OperationBuilder<GetAllPodConfigClientBuilder>
        {





            internal GetAllPodConfigClientBuilder() { }






            public GetAllPodConfigClient Build(
                string namespace_,
                long count,
                long offset
            )
            {
                GetAllPodConfigClient op = new GetAllPodConfigClient(this,
                    namespace_,
                    count,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetAllPodConfigClient(GetAllPodConfigClientBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;


            QueryParams["count"] = Convert.ToString(count)!;

            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllPodConfigClient(
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;


            QueryParams["count"] = Convert.ToString(count)!;

            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/configs/pods";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListPodConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsListPodConfigResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsListPodConfigResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPodConfigResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}