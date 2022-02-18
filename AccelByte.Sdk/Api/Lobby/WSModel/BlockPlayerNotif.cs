// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("blockPlayerNotif")]
    public class BlockPlayerNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("userId")]
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [AwesomeProperty("blockedUserId")]
        [JsonPropertyName("blockedUserId")]
        public string? BlockedUserId { get; set; }
        
    }
}