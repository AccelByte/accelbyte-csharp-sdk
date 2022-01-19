using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetPublisherUserResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }
        
    }
}