using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelCountryLocationResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("city")]
        public string? City { get; set; }
        
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("countryName")]
        public string? CountryName { get; set; }
        
        [JsonPropertyName("state")]
        public string? State { get; set; }
        
    }
}