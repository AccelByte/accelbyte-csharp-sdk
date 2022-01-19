using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkStatItemInc : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("inc")]
        public double? Inc { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
    }
}