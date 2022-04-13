// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelCountryV3Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ageRestriction")]
        public int? AgeRestriction { get; set; }

        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("countryName")]
        public string? CountryName { get; set; }

        [JsonPropertyName("enable")]
        public bool? Enable { get; set; }

    }
}