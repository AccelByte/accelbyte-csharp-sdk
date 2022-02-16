// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("defaultValue")]
        public double? DefaultValue { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("incrementOnly")]
        public bool? IncrementOnly { get; set; }
        
        [JsonPropertyName("maximum")]
        public double? Maximum { get; set; }
        
        [JsonPropertyName("minimum")]
        public double? Minimum { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("setAsGlobal")]
        public bool? SetAsGlobal { get; set; }
        
        [JsonPropertyName("setBy")]
        public string? SetBy { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}