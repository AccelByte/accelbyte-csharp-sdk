using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserActiveBanResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ban")]
        public string? Ban { get; set; }
        
        [JsonPropertyName("banId")]
        public string? BanId { get; set; }
        
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
    }
}