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
    /// FleetServerConnectionInfo
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:DS:LOGS [READ]
    /// </summary>
    public class FleetServerConnectionInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetServerConnectionInfoBuilder Builder { get => new FleetServerConnectionInfoBuilder(); }

        public class FleetServerConnectionInfoBuilder
            : OperationBuilder<FleetServerConnectionInfoBuilder>
        {





            internal FleetServerConnectionInfoBuilder() { }






            public FleetServerConnectionInfo Build(
                string namespace_,
                string serverID
            )
            {
                FleetServerConnectionInfo op = new FleetServerConnectionInfo(this,
                    namespace_,                    
                    serverID                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private FleetServerConnectionInfo(FleetServerConnectionInfoBuilder builder,
            string namespace_,
            string serverID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["serverID"] = serverID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetServerConnectionInfo(
            string namespace_,            
            string serverID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["serverID"] = serverID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/servers/{serverID}/connectioninfo";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApiFleetServerConnectionInfoResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiFleetServerConnectionInfoResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiFleetServerConnectionInfoResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetServerConnectionInfoResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}