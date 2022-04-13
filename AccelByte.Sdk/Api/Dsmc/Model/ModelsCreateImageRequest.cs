// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreateImageRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("artifactPath")]
        public string? ArtifactPath { get; set; }

        [JsonPropertyName("dockerPath")]
        public string? DockerPath { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

    }
}