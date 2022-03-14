// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserVerificationRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("contactType")]
        public string? ContactType { get; set; }
        
        [JsonPropertyName("languageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("validateOnly")]
        public bool? ValidateOnly { get; set; }
        
    }
}