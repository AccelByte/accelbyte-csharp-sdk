// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserPlatformMetadata : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("metadata")]
        public Dictionary<string, object>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class ModelUserPlatformMetadata<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("metadata")]
        public T1? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

}