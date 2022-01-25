using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class IAPItemConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<IAPItemEntry>? Data { get; set; }
        
    }
}