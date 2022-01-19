using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemId : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        public string? ItemId_ { get; set; }
        
    }
}