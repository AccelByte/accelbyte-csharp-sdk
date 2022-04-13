// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminUpdateProfanityList : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }

        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("newName")]
        public string? NewName { get; set; }

    }
}