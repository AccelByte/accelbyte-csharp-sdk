using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UploadLocalizedPolicyVersionAttachmentResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attachmentChecksum")]
        public string? AttachmentChecksum { get; set; }
        
        [JsonPropertyName("attachmentLocation")]
        public string? AttachmentLocation { get; set; }
        
        [JsonPropertyName("attachmentUploadUrl")]
        public string? AttachmentUploadUrl { get; set; }
        
    }
}