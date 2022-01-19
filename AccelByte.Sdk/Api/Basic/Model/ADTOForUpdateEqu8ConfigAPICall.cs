using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class ADTOForUpdateEqu8ConfigAPICall : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
    }
}