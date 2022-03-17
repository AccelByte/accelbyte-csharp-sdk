// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("unblockPlayerNotif")]
    public class UnblockPlayerNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("unblockedUserId")]
        [JsonPropertyName("unblockedUserId")]
        public string? UnblockedUserId { get; set; }
        
        [AwesomeProperty("userId")]
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}