using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelAgeRestrictionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgeRestriction")]
        public int? AgeRestriction { get; set; }
        
        [JsonPropertyName("Enable")]
        public bool? Enable { get; set; }
        
    }
}