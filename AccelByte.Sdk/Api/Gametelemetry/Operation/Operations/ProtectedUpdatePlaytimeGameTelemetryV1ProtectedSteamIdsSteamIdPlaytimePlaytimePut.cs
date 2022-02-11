using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// protected_update_playtime_game_telemetry_v1_protected_steamIds__steamId__playtime__playtime__put
    ///
    /// This endpoint requires valid JWT token. This endpoint does not require
    /// permission. This endpoint update player's total playtime in a specific game
    /// (AppId) from service's cache.
    /// </summary>
    public class ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut : AccelByte.Sdk.Core.Operation
    {
        public ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut(
            string playtime,            
            string steamId            
        )
        {
            PathParams["playtime"] = playtime;
            PathParams["steamId"] = steamId;
            
            
            
            
            
        }

        public override string Path => "/game-telemetry/v1/protected/steamIds/{steamId}/playtime/{playtime}";

        public override HttpMethod Method => HttpMethod.Put;

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