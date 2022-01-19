using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UploadPolicyVersionAttachmentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentMD5")]
        public string? ContentMD5 { get; set; }
        
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
    }
}