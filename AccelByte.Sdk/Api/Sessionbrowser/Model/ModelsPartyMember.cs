// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsPartyMember : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extra_attributes")]
        public Dictionary<string, object>? ExtraAttributes { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }
}