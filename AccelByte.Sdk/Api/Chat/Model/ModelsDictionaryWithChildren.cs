// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Chat.Model
{
    public class ModelsDictionaryWithChildren : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("falseNegatives")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsDictionaryChild>? FalseNegatives { get; set; }

        [JsonPropertyName("falsePositives")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsDictionaryChild>? FalsePositives { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        [JsonPropertyName("word")]
        public string? Word { get; set; }

        [JsonPropertyName("wordType")]
        public string? WordType { get; set; }

    }


}