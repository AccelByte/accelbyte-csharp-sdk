// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class LogAppMessageDeclaration : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Attributes")]
        public List<string>? Attributes { get; set; }
        
        [JsonPropertyName("Code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("CodeName")]
        public string? CodeName { get; set; }
        
        [JsonPropertyName("Section")]
        public string? Section { get; set; }
        
        [JsonPropertyName("Service")]
        public string? Service { get; set; }
        
        [JsonPropertyName("Text")]
        public string? Text { get; set; }
        
    }
}