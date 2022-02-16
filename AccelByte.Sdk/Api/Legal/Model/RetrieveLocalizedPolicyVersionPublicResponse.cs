// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveLocalizedPolicyVersionPublicResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attachmentChecksum")]
        public string? AttachmentChecksum { get; set; }
        
        [JsonPropertyName("attachmentLocation")]
        public string? AttachmentLocation { get; set; }
        
        [JsonPropertyName("attachmentVersionIdentifier")]
        public string? AttachmentVersionIdentifier { get; set; }
        
        [JsonPropertyName("basePolicyId")]
        public string? BasePolicyId { get; set; }
        
        [JsonPropertyName("baseUrls")]
        public List<string>? BaseUrls { get; set; }
        
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("localeCode")]
        public string? LocaleCode { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("policy")]
        public PolicyObject? Policy { get; set; }
        
        [JsonPropertyName("policyVersion")]
        public PolicyVersionObject? PolicyVersion { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}