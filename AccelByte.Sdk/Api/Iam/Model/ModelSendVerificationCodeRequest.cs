// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSendVerificationCodeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Context")]
        public string? Context { get; set; }
        
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("LoginID")]
        public string? LoginID { get; set; }
        
    }
}