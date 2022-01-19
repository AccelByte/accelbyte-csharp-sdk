using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class SlotConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxSlotSize")]
        public int? MaxSlotSize { get; set; }
        
        [JsonPropertyName("maxSlots")]
        public int? MaxSlots { get; set; }
        
    }
}