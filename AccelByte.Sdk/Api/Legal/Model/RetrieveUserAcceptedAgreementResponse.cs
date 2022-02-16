// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveUserAcceptedAgreementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("isAccepted")]
        public bool? IsAccepted { get; set; }
        
        [JsonPropertyName("localizedPolicyVersion")]
        public LocalizedPolicyVersionObject? LocalizedPolicyVersion { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }
        
        [JsonPropertyName("policyType")]
        public string? PolicyType { get; set; }
        
        [JsonPropertyName("publisherUserId")]
        public string? PublisherUserId { get; set; }
        
        [JsonPropertyName("signingDate")]
        public DateTime? SigningDate { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        
    }
}