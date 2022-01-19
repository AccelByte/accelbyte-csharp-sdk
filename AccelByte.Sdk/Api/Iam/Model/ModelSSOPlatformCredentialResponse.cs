using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSSOPlatformCredentialResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acsUrl")]
        public string? AcsUrl { get; set; }
        
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("federationMetadataUrl")]
        public string? FederationMetadataUrl { get; set; }
        
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }
        
        [JsonPropertyName("secret")]
        public string? Secret { get; set; }
        
        [JsonPropertyName("ssoUrl")]
        public string? SsoUrl { get; set; }
        
        [JsonPropertyName("truncatedApiKey")]
        public string? TruncatedApiKey { get; set; }
        
    }
}