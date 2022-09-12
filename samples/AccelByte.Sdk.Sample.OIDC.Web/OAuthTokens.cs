// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Sample.OIDC.Web
{
    public class OAuthTokens
    {
        [JsonPropertyName("access_token")]
        public string Access { get; set; } = String.Empty;

        [JsonPropertyName("refresh_token")]
        public string Refresh { get; set; } = String.Empty;

        [JsonPropertyName("id_token")]
        public string ID { get; set; } = String.Empty;

        [JsonPropertyName("token_type")]
        public string Type { get; set; } = String.Empty;
    }
}