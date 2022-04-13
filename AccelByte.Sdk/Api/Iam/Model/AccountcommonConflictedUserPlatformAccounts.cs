// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonConflictedUserPlatformAccounts : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformUserID")]
        public string? PlatformUserID { get; set; }

        [JsonPropertyName("publisherAccounts")]
        public List<AccountcommonUserWithLinkedPlatformAccounts>? PublisherAccounts { get; set; }

    }
}