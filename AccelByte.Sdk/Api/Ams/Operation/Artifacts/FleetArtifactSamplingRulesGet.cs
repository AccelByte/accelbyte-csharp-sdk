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
    /// FleetArtifactSamplingRulesGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:ARTIFACT [READ]
    /// </summary>
    public class FleetArtifactSamplingRulesGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetArtifactSamplingRulesGetBuilder Builder { get => new FleetArtifactSamplingRulesGetBuilder(); }

        public class FleetArtifactSamplingRulesGetBuilder
            : OperationBuilder<FleetArtifactSamplingRulesGetBuilder>
        {





            internal FleetArtifactSamplingRulesGetBuilder() { }






            public FleetArtifactSamplingRulesGet Build(
                string fleetID,
                string namespace_
            )
            {
                FleetArtifactSamplingRulesGet op = new FleetArtifactSamplingRulesGet(this,
                    fleetID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private FleetArtifactSamplingRulesGet(FleetArtifactSamplingRulesGetBuilder builder,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetArtifactSamplingRulesGet(
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/artifacts-sampling-rules";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiFleetArtifactsSampleRules? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiFleetArtifactsSampleRules>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiFleetArtifactsSampleRules>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetArtifactsSampleRules>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}