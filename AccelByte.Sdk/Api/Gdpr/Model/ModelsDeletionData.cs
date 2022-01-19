using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsDeletionData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("RequestDate")]
        public DateTime? RequestDate { get; set; }
        
        [JsonPropertyName("Status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}