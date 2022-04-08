// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// admin_get_events_game_telemetry_v1_admin_events_get
    ///
    /// This endpoint requires valid JWT token and permission **ADMIN:ANALYTICS:TELEMETRY:{EventNamespace}** **READ**.
    /// 
    /// This endpoint retrieve the latest event from each event name on specific namespace.
    /// 
    /// 
    /// 
    /// Parameter:
    /// 
    /// - **Namespace (required) (case-sensitive)**: telemetry namespace.
    /// 
    /// 
    /// Only accept input with valid characters. Allowed characters: Aa-Zz0-9_.-
    /// 
    /// 
    /// 
    /// 
    /// Example: accelbyte or accelbyte.game2
    /// </summary>
    public class AdminGetEventsGameTelemetryV1AdminEventsGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetEventsGameTelemetryV1AdminEventsGetBuilder Builder = new AdminGetEventsGameTelemetryV1AdminEventsGetBuilder();

        public class AdminGetEventsGameTelemetryV1AdminEventsGetBuilder
        {
            
            internal AdminGetEventsGameTelemetryV1AdminEventsGetBuilder() { }





            public AdminGetEventsGameTelemetryV1AdminEventsGet Build(
                string namespace_
            )
            {
                return new AdminGetEventsGameTelemetryV1AdminEventsGet(this,
                    namespace_                    
                );
            }
        }

        private AdminGetEventsGameTelemetryV1AdminEventsGet(AdminGetEventsGameTelemetryV1AdminEventsGetBuilder builder,
            string namespace_
        )
        {
            
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            
            
            
            
        }
        #endregion

        public AdminGetEventsGameTelemetryV1AdminEventsGet(
            string namespace_            
        )
        {
            
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/game-telemetry/v1/admin/events";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}