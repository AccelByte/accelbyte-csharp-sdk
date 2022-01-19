using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelCountryV3Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ageRestriction")]
        public int? AgeRestriction { get; set; }
        
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("countryName")]
        public string? CountryName { get; set; }
        
        [JsonPropertyName("enable")]
        public bool? Enable { get; set; }
        
    }
}