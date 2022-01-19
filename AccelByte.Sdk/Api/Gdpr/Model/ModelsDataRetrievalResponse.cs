using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsDataRetrievalResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("RequestDate")]
        public DateTime? RequestDate { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}