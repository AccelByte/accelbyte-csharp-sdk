// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Requirement : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionals")]
        public string? Additionals { get; set; }
        
        [JsonPropertyName("directXVersion")]
        public string? DirectXVersion { get; set; }
        
        [JsonPropertyName("diskSpace")]
        public string? DiskSpace { get; set; }
        
        [JsonPropertyName("graphics")]
        public string? Graphics { get; set; }
        
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        
        [JsonPropertyName("osVersion")]
        public string? OsVersion { get; set; }
        
        [JsonPropertyName("processor")]
        public string? Processor { get; set; }
        
        [JsonPropertyName("ram")]
        public string? Ram { get; set; }
        
        [JsonPropertyName("soundCard")]
        public string? SoundCard { get; set; }
        
    }
}