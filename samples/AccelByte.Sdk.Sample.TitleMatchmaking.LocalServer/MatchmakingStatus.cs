// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class MatchmakingStatus
    {
        [JsonPropertyName("is_active_matchmaking_available")]
        public bool IsActiveMatchmakingAvailable { get; set; } = false;

        [JsonPropertyName("channel_slug")]
        public string ChannelSlug { get; set; } = String.Empty;

        [JsonPropertyName("members")]
        public List<PartyData> Members { get; set; } = new List<PartyData>();
    }
}