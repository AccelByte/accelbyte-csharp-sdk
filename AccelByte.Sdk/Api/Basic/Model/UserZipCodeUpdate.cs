using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserZipCodeUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
        
    }
}