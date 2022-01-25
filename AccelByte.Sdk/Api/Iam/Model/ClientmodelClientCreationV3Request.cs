using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientCreationV3Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("audiences")]
        public List<string>? Audiences { get; set; }
        
        [JsonPropertyName("baseUri")]
        public string? BaseUri { get; set; }
        
        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("clientName")]
        public string? ClientName { get; set; }
        
        [JsonPropertyName("clientPermissions")]
        public List<AccountcommonPermissionV3>? ClientPermissions { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("oauthClientType")]
        public string? OauthClientType { get; set; }
        
        [JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }
        
        [JsonPropertyName("secret")]
        public string? Secret { get; set; }
        
    }
}