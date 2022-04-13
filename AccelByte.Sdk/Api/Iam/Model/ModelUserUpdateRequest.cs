// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Country")]
        public string? Country { get; set; }

        [JsonPropertyName("DateOfBirth")]
        public string? DateOfBirth { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }

    }
}