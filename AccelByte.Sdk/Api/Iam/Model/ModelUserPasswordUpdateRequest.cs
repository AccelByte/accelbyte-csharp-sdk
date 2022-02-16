// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserPasswordUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("NewPassword")]
        public string? NewPassword { get; set; }
        
        [JsonPropertyName("OldPassword")]
        public string? OldPassword { get; set; }
        
    }
}