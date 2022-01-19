using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelEmailUpdateRequestV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
    }
}