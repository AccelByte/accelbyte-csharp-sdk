// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class UserPassGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("passCode")]
        public string? PassCode { get; set; }

        [JsonPropertyName("passItemId")]
        public string? PassItemId { get; set; }

    }
}