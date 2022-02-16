// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSSOPlatformCredentialRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acsUrl")]
        public string? AcsUrl { get; set; }
        
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("federationMetadataUrl")]
        public string? FederationMetadataUrl { get; set; }
        
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
        
        [JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }
        
        [JsonPropertyName("secret")]
        public string? Secret { get; set; }
        
        [JsonPropertyName("ssoUrl")]
        public string? SsoUrl { get; set; }
        
    }
}