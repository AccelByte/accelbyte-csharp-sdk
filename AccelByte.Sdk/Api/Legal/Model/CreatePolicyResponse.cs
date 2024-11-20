// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreatePolicyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Countries { get; set; }

        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("countryGroupName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryGroupName { get; set; }

        [JsonPropertyName("countryType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryType { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isDefaultSelection")]
        public bool? IsDefaultSelection { get; set; }

        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }

        [JsonPropertyName("policyVersions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PolicyVersionObject>? PolicyVersions { get; set; }

        [JsonPropertyName("readableId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReadableId { get; set; }

        [JsonPropertyName("shouldNotifyOnUpdate")]
        public bool? ShouldNotifyOnUpdate { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

    }


}