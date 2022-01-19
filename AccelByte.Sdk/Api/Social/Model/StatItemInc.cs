using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatItemInc : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("inc")]
        public double? Inc { get; set; }
        
    }
}