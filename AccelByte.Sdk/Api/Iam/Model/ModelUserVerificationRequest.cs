// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserVerificationRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("ContactType")]
        public string? ContactType { get; set; }
        
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("validateOnly")]
        public bool? ValidateOnly { get; set; }
        
    }
}