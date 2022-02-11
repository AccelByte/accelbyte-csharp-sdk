using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// protected_get_playtime_game_telemetry_v1_protected_steamIds__steamId__playtime_get
    ///
    /// This endpoint requires valid JWT token. This endpoint does not require
    /// permission. This endpoint retrieves player's total playtime in Steam for a
    /// specific game (AppId) and store them in service's cache. Players' Steam
    /// account must be set into public to enable the service fetch their total
    /// playtime data.
    /// </summary>
    public class ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet : AccelByte.Sdk.Core.Operation
    {
        public ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet(
            string steamId            
        )
        {
            PathParams["steamId"] = steamId;
            
            
            
            
            
        }

        public override string Path => "/game-telemetry/v1/protected/steamIds/{steamId}/playtime";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public long? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<long>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<long>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}