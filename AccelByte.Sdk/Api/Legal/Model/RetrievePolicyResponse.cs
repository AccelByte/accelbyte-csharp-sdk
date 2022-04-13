// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrievePolicyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("countryGroupCode")]
        public string? CountryGroupCode { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isDefaultOpted")]
        public bool? IsDefaultOpted { get; set; }

        [JsonPropertyName("isDefaultSelection")]
        public bool? IsDefaultSelection { get; set; }

        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }

        [JsonPropertyName("policyVersions")]
        public List<PolicyVersionObject>? PolicyVersions { get; set; }

        [JsonPropertyName("readableId")]
        public string? ReadableId { get; set; }

        [JsonPropertyName("shouldNotifyOnUpdate")]
        public bool? ShouldNotifyOnUpdate { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }
}