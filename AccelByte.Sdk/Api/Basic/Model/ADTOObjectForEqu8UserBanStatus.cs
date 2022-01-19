using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class ADTOObjectForEqu8UserBanStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("expires")]
        public DateTime? Expires { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}