// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class HierarchicalCategoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("childCategories")]
        public List<HierarchicalCategoryInfo>? ChildCategories { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("parentCategoryPath")]
        public string? ParentCategoryPath { get; set; }

        [JsonPropertyName("root")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Root { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }
}