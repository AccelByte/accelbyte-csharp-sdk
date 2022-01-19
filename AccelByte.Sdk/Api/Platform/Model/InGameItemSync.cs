using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class InGameItemSync : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }
        
        [JsonPropertyName("targetItemId")]
        public string? TargetItemId { get; set; }
        
        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }
        
    }
}