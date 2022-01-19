using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonCountryAgeRestriction : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgeRestriction")]
        public int? AgeRestriction { get; set; }
        
        [JsonPropertyName("CountryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("CountryName")]
        public string? CountryName { get; set; }
        
        [JsonPropertyName("Enable")]
        public bool? Enable { get; set; }
        
    }
}