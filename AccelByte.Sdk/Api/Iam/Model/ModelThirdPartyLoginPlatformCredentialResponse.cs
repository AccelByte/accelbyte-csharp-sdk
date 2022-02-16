// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelThirdPartyLoginPlatformCredentialResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ACSURL")]
        public string? ACSURL { get; set; }
        
        [JsonPropertyName("AWSCognitoRegion")]
        public string? AWSCognitoRegion { get; set; }
        
        [JsonPropertyName("AWSCognitoUserPool")]
        public string? AWSCognitoUserPool { get; set; }
        
        [JsonPropertyName("AppId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("ClientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("Environment")]
        public string? Environment { get; set; }
        
        [JsonPropertyName("FederationMetadataURL")]
        public string? FederationMetadataURL { get; set; }
        
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get; set; }
        
        [JsonPropertyName("KeyID")]
        public string? KeyID { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("OrganizationId")]
        public string? OrganizationId { get; set; }
        
        [JsonPropertyName("PlatformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("RedirectUri")]
        public string? RedirectUri { get; set; }
        
        [JsonPropertyName("Secret")]
        public string? Secret { get; set; }
        
        [JsonPropertyName("TeamID")]
        public string? TeamID { get; set; }
        
        [JsonPropertyName("registeredDomains")]
        public List<AccountcommonRegisteredDomain>? RegisteredDomains { get; set; }
        
    }
}