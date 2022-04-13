// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserInformation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Country")]
        public string? Country { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("EmailAddresses")]
        public List<string>? EmailAddresses { get; set; }

        [JsonPropertyName("LinkedPlatformAccounts")]
        public List<ModelPlatformUserInformation>? LinkedPlatformAccounts { get; set; }

        [JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("Username")]
        public string? Username { get; set; }

        [JsonPropertyName("XUID")]
        public string? XUID { get; set; }

    }
}