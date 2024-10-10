// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveUserEligibilitiesResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("baseUrls")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? BaseUrls { get; set; }

        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("countryGroupCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryGroupCode { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("isAccepted")]
        public bool? IsAccepted { get; set; }

        [JsonPropertyName("isHiddenPublic")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsHiddenPublic { get; set; }

        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("policyId")]
        public string? PolicyId { get; set; }

        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }

        [JsonPropertyName("policyType")]
        public string? PolicyType { get; set; }

        [JsonPropertyName("policyVersions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PolicyVersionWithLocalizedVersionObject>? PolicyVersions { get; set; }

        [JsonPropertyName("readableId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReadableId { get; set; }

    }


}