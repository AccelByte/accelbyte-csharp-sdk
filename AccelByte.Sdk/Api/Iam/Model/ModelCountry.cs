// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelCountry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgeRestriction")]
        public int? AgeRestriction { get; set; }
        
        [JsonPropertyName("CountryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("CountryName")]
        public string? CountryName { get; set; }
        
        [JsonPropertyName("Enable")]
        public bool? Enable { get; set; }
        
    }
}