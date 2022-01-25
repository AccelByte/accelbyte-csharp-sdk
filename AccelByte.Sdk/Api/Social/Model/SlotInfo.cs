using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class SlotInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("checksum")]
        public string? Checksum { get; set; }
        
        [JsonPropertyName("customAttribute")]
        public string? CustomAttribute { get; set; }
        
        [JsonPropertyName("dateAccessed")]
        public DateTime? DateAccessed { get; set; }
        
        [JsonPropertyName("dateCreated")]
        public DateTime? DateCreated { get; set; }
        
        [JsonPropertyName("dateModified")]
        public DateTime? DateModified { get; set; }
        
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        
        [JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("originalName")]
        public string? OriginalName { get; set; }
        
        [JsonPropertyName("size")]
        public long? Size { get; set; }
        
        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }
        
        [JsonPropertyName("storedName")]
        public string? StoredName { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}