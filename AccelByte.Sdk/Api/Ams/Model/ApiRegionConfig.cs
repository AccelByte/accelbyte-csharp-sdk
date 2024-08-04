// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiRegionConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("bufferSize")]
        public int? BufferSize { get; set; }

        [JsonPropertyName("dynamicBuffer")]
        public bool? DynamicBuffer { get; set; }

        [JsonPropertyName("maxServerCount")]
        public int? MaxServerCount { get; set; }

        [JsonPropertyName("minServerCount")]
        public int? MinServerCount { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

    }


}