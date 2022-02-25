// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("channelChatNotif")]
    public class ChannelChatNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("channelSlug")]
        [JsonPropertyName("channelSlug")]
        public string? ChannelSlug { get; set; }
        
        [AwesomeProperty("from")]
        [JsonPropertyName("from")]
        public string? From { get; set; }
        
        [AwesomeProperty("payload")]
        [JsonPropertyName("payload")]
        public string? Payload { get; set; }
        
        [AwesomeProperty("sentAt")]
        [JsonPropertyName("sentAt")]
        public string? SentAt { get; set; }
        
    }
}