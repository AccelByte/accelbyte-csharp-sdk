using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserInfoResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}