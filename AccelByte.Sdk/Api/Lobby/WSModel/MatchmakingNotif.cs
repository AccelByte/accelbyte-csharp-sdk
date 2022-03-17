// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("matchmakingNotif")]
    public class MatchmakingNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("counterPartyMember")]
        [JsonPropertyName("counterPartyMember")]
        public List<string>? CounterPartyMember { get; set; }
        
        [AwesomeProperty("matchId")]
        [JsonPropertyName("matchId")]
        public string? MatchId { get; set; }
        
        [AwesomeProperty("message")]
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
        [AwesomeProperty("partyMember")]
        [JsonPropertyName("partyMember")]
        public List<string>? PartyMember { get; set; }
        
        [AwesomeProperty("readyDuration")]
        [JsonPropertyName("readyDuration")]
        public long? ReadyDuration { get; set; }
        
        [AwesomeProperty("status")]
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}