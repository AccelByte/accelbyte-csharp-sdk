// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsDSMConfigRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claim_timeout")]
        public int? ClaimTimeout { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("creation_timeout")]
        public int? CreationTimeout { get; set; }

        [JsonPropertyName("default_version")]
        public string? DefaultVersion { get; set; }

        [JsonPropertyName("modifiedBy")]
        public string? ModifiedBy { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("port")]
        public int? Port { get; set; }

        [JsonPropertyName("ports")]
        public Dictionary<string, long>? Ports { get; set; }

        [JsonPropertyName("protocol")]
        public string? Protocol { get; set; }

        [JsonPropertyName("providers")]
        public List<string>? Providers { get; set; }

        [JsonPropertyName("session_timeout")]
        public int? SessionTimeout { get; set; }

        [JsonPropertyName("unreachable_timeout")]
        public int? UnreachableTimeout { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }
}