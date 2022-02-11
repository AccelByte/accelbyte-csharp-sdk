using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class TierReorder : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("newIndex")]
        public int? NewIndex { get; set; }
        
    }
}