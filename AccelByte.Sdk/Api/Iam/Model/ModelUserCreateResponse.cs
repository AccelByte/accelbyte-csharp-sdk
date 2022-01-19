using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserCreateResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AuthType")]
        public string? AuthType { get; set; }
        
        [JsonPropertyName("Country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("LoginId")]
        public string? LoginId { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }
        
    }
}