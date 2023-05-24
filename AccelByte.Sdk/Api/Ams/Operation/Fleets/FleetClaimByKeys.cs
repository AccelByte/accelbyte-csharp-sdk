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
    /// FleetClaimByKeys
    ///
    /// Required Permission: NAMESPACE:{namespace}:ARMADA:FLEET [UPDATE]
    /// </summary>
    public class FleetClaimByKeys : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetClaimByKeysBuilder Builder { get => new FleetClaimByKeysBuilder(); }

        public class FleetClaimByKeysBuilder
            : OperationBuilder<FleetClaimByKeysBuilder>
        {





            internal FleetClaimByKeysBuilder() { }






            public FleetClaimByKeys Build(
                ApiFleetClaimReq body,
                string namespace_
            )
            {
                FleetClaimByKeys op = new FleetClaimByKeys(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private FleetClaimByKeys(FleetClaimByKeysBuilder builder,
            ApiFleetClaimReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetClaimByKeys(
            string namespace_,
            Model.ApiFleetClaimReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/namespaces/{namespace}/servers/claim";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiFleetClaimResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetClaimResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetClaimResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}