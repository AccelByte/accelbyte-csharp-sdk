using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class CountryObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}