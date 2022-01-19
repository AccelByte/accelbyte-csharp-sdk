using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatItemIncResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentValue")]
        public double? CurrentValue { get; set; }
        
    }
}