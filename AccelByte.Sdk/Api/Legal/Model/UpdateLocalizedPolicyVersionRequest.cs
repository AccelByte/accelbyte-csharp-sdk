using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UpdateLocalizedPolicyVersionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attachmentChecksum")]
        public string? AttachmentChecksum { get; set; }
        
        [JsonPropertyName("attachmentLocation")]
        public string? AttachmentLocation { get; set; }
        
        [JsonPropertyName("attachmentVersionIdentifier")]
        public string? AttachmentVersionIdentifier { get; set; }
        
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
    }
}