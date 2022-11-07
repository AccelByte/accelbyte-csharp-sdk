// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("startMatchmakingRequest")]
    public class StartMatchmakingRequest : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("extraAttributes")]
        [JsonPropertyName("extraAttributes")]
        public string? ExtraAttributes { get; set; }
        
        [AwesomeProperty("gameMode")]
        [JsonPropertyName("gameMode")]
        public string? GameMode { get; set; }
        
        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [AwesomeProperty("partyAttributes")]
        [JsonPropertyName("partyAttributes")]
        public Dictionary<string, object>? PartyAttributes { get; set; }
        
        [AwesomeProperty("priority")]
        [JsonPropertyName("priority")]
        public long? Priority { get; set; }
        
        [AwesomeProperty("tempParty")]
        [JsonPropertyName("tempParty")]
        public string? TempParty { get; set; }
        
    }
}