using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelAgeRestrictionResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ageRestriction")]
        public int? AgeRestriction { get; set; }
        
        [JsonPropertyName("enable")]
        public bool? Enable { get; set; }
        
    }
}