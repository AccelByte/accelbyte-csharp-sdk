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
    /// GetLowestInstanceSpec
    ///
    /// Required permission: ADMIN:NAMESPACE:*:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint returns the lowest instance spec, both cpu (in Mhz) and memory (in Mb).
    /// </summary>
    public class GetLowestInstanceSpec : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLowestInstanceSpecBuilder Builder { get => new GetLowestInstanceSpecBuilder(); }

        public class GetLowestInstanceSpecBuilder
            : OperationBuilder<GetLowestInstanceSpecBuilder>
        {





            internal GetLowestInstanceSpecBuilder() { }






            public GetLowestInstanceSpec Build(
            )
            {
                GetLowestInstanceSpec op = new GetLowestInstanceSpec(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetLowestInstanceSpec(GetLowestInstanceSpecBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLowestInstanceSpec(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/instances/spec/lowest";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsInstanceSpec? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsInstanceSpec>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsInstanceSpec>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsInstanceSpec>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}