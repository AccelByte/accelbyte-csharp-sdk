using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsRequestDeleteResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}