// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserSearchByPlatformIDResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("EmailAddress")]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("LinkedPlatforms")]
        public List<AccountcommonUserLinkedPlatform>? LinkedPlatforms { get; set; }

        [JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }

    }
}