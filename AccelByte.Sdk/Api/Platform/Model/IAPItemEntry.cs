using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class IAPItemEntry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemIdentity")]
        public string? ItemIdentity { get; set; }
        
        [JsonPropertyName("platformProductIdMap")]
        public Dictionary<string, string>? PlatformProductIdMap { get; set; }
        
    }
}