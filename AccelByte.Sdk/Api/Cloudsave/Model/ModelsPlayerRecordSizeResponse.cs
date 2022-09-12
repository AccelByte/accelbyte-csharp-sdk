// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsPlayerRecordSizeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("current_size")]
        public long? CurrentSize { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("remaining_size")]
        public long? RemainingSize { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }
}