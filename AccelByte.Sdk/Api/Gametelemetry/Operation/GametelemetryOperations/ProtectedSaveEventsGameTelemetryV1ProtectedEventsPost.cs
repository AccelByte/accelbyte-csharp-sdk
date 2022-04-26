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
    /// protected_save_events_game_telemetry_v1_protected_events_post
    ///
    /// This endpoint requires valid JWT token.
    /// This endpoint does not require permission.
    /// 
    /// This endpoint send events into designated streaming pipeline and each request can contain single or multiple events.
    /// 
    /// 
    /// Format of the event:
    /// 
    /// - **EventNamespace (required)**: namespace of the relevant game with domain name format.
    /// 
    /// 
    /// Only accept input with valid characters. Allowed characters: Aa-Zz0-9_.-
    /// 
    /// 
    /// 
    /// 
    /// It is encouraged to use alphanumeric only characters. _.- will be deprecated soon
    /// 
    /// 
    /// 
    /// 
    /// Example: io.accelbyte.justice.dev.samplegame
    /// 
    /// 
    /// 
    /// - **EventName (required)**: name of the event.
    /// 
    /// 
    /// Only accept input with valid characters. Allowed characters: Aa-Zz0-9_.-
    /// 
    /// 
    /// 
    /// 
    /// It is encouraged to use alphanumeric only characters. _.- will be deprecated soon
    /// 
    /// 
    /// 
    /// 
    /// Example: player_killed, mission_accomplished
    /// 
    /// 
    /// 
    /// - **Payload (required)**: an arbitrary json with the payload of the said event
    /// </summary>
    public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder Builder = new ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder();

        public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder
            : OperationBuilder<ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder>
        {
            
            
            internal ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder() { }






            public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost Build(
                List<TelemetryBody> body,
                string accessToken            )
            {
                ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost op = new ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(this,
                    body,                    
                    accessToken
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder builder,
            List<TelemetryBody> body,
            string accessToken            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }
        #endregion

        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(
            List<Model.TelemetryBody> body,            
            string accessToken
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }

        public override string Path => "/game-telemetry/v1/protected/events";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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