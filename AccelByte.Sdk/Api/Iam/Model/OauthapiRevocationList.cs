// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthapiRevocationList : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("revoked_tokens")]
        public BloomFilterJSON? RevokedTokens { get; set; }

        [JsonPropertyName("revoked_users")]
        public List<OauthcommonUserRevocationListRecord>? RevokedUsers { get; set; }

    }
}