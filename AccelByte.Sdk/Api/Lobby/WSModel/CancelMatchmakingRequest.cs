// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("cancelMatchmakingRequest")]
    public class CancelMatchmakingRequest : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [AwesomeProperty("gameMode")]
        [JsonPropertyName("gameMode")]
        public string? GameMode { get; set; }
        
        [AwesomeProperty("isTempParty")]
        [JsonPropertyName("isTempParty")]
        public bool? IsTempParty { get; set; }
        
    }
}