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
    /// FleetUpdate
    ///
    /// Optionally, sampling rules for the fleet can also be updated
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [UPDATE]
    /// </summary>
    public class FleetUpdate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetUpdateBuilder Builder { get => new FleetUpdateBuilder(); }

        public class FleetUpdateBuilder
            : OperationBuilder<FleetUpdateBuilder>
        {





            internal FleetUpdateBuilder() { }






            public FleetUpdate Build(
                ApiFleetParameters body,
                string fleetID,
                string namespace_
            )
            {
                FleetUpdate op = new FleetUpdate(this,
                    body,
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

        private FleetUpdate(FleetUpdateBuilder builder,
            ApiFleetParameters body,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetUpdate(
            string fleetID,
            string namespace_,
            Model.ApiFleetParameters body
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}