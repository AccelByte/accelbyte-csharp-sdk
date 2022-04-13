// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserBanRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("actionId")]
        public int? ActionId { get; set; }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }

    }
}