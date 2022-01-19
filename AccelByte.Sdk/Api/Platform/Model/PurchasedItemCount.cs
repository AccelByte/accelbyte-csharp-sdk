using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PurchasedItemCount : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("count")]
        public long? Count { get; set; }
        
    }
}