using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RedeemResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("items")]
        public List<RedeemableItem>? Items { get; set; }
        
    }
}