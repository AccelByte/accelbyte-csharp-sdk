using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class ADTOObjectForEqu8UserStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("actionComment")]
        public string? ActionComment { get; set; }
        
        [JsonPropertyName("actionId")]
        public int? ActionId { get; set; }
        
        [JsonPropertyName("expires")]
        public DateTime? Expires { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("when")]
        public DateTime? When { get; set; }
        
    }
}