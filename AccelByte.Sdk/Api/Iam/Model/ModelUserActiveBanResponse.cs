using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserActiveBanResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Ban")]
        public string? Ban { get; set; }
        
        [JsonPropertyName("BanId")]
        public string? BanId { get; set; }
        
        [JsonPropertyName("EndDate")]
        public DateTime? EndDate { get; set; }
        
    }
}