// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gametelemetry.Model
{
    public class ValidationError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("loc")]
        public List<string>? Loc { get; set; }
        
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}