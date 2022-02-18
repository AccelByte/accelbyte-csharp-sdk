// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("signalingP2PNotif")]
    public class SignalingP2PNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("destinationId")]
        [JsonPropertyName("destinationId")]
        public string? DestinationId { get; set; }
        
        [AwesomeProperty("message")]
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
    }
}