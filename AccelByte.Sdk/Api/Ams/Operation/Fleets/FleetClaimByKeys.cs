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
    /// Claim a dedicated server from fleets with matching claim keys
    /// 
    /// Required Permission: NAMESPACE:{namespace}:AMS:SERVER:CLAIM [UPDATE]
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
                ApiFleetClaimByKeysReq body,
                string namespace_
            )
            {
                FleetClaimByKeys op = new FleetClaimByKeys(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private FleetClaimByKeys(FleetClaimByKeysBuilder builder,
            ApiFleetClaimByKeysReq body,
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
            Model.ApiFleetClaimByKeysReq body            
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
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiFleetClaimResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiFleetClaimResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetClaimResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}