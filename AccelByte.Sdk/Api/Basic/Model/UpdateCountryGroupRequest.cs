using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UpdateCountryGroupRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countries")]
        public List<CountryObject>? Countries { get; set; }
        
        [JsonPropertyName("countryGroupName")]
        public string? CountryGroupName { get; set; }
        
    }
}