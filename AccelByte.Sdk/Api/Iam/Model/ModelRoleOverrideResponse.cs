// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleOverrideResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("additions")]
        public List<AccountcommonOverrideRolePermission>? Additions { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("exclusions")]
        public List<AccountcommonOverrideRolePermission>? Exclusions { get; set; }

        [JsonPropertyName("identity")]
        public string? Identity { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("overrides")]
        public List<AccountcommonOverrideRolePermission>? Overrides { get; set; }

        [JsonPropertyName("replacements")]
        public List<AccountcommonReplaceRolePermission>? Replacements { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

    }


}