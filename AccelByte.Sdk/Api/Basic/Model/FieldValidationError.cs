// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class FieldValidationError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }
        
        [JsonPropertyName("errorField")]
        public string? ErrorField { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
        [JsonPropertyName("errorValue")]
        public string? ErrorValue { get; set; }
        
        [JsonPropertyName("messageVariables")]
        public Dictionary<string, string>? MessageVariables { get; set; }
        
    }
}