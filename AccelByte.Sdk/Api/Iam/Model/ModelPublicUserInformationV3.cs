using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPublicUserInformationV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("userName")]
        public string? UserName { get; set; }
        
    }
}