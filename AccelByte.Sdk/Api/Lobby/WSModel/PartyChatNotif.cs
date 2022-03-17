// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("partyChatNotif")]
    public class PartyChatNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("from")]
        [JsonPropertyName("from")]
        public string? From { get; set; }
        
        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [AwesomeProperty("payload")]
        [JsonPropertyName("payload")]
        public string? Payload { get; set; }
        
        [AwesomeProperty("receivedAt")]
        [JsonPropertyName("receivedAt")]
        public long? ReceivedAt { get; set; }
        
        [AwesomeProperty("to")]
        [JsonPropertyName("to")]
        public string? To { get; set; }
        
    }
}