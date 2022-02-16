// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreateBasePolicyRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIds")]
        public List<string>? AffectedClientIds { get; set; }
        
        [JsonPropertyName("affectedCountries")]
        public List<string>? AffectedCountries { get; set; }
        
        [JsonPropertyName("basePolicyName")]
        public string? BasePolicyName { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("typeId")]
        public string? TypeId { get; set; }
        
    }
}