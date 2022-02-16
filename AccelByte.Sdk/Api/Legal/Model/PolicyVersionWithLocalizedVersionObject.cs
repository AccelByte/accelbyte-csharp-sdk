// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class PolicyVersionWithLocalizedVersionObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("displayVersion")]
        public string? DisplayVersion { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("isCommitted")]
        public bool? IsCommitted { get; set; }
        
        [JsonPropertyName("isInEffect")]
        public bool? IsInEffect { get; set; }
        
        [JsonPropertyName("localizedPolicyVersions")]
        public List<LocalizedPolicyVersionObject>? LocalizedPolicyVersions { get; set; }
        
        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}