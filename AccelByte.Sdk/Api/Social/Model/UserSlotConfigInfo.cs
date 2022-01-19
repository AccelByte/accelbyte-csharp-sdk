using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class UserSlotConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxSlotSize")]
        public int? MaxSlotSize { get; set; }
        
        [JsonPropertyName("maxSlots")]
        public int? MaxSlots { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}