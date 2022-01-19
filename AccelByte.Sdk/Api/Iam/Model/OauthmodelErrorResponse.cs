using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelErrorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        
        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }
        
        [JsonPropertyName("error_uri")]
        public string? ErrorUri { get; set; }
        
    }
}