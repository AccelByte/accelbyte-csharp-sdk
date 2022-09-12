// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("friendsStatusResponse")]
    public class FriendsStatusResponse : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("activity")]
        [JsonPropertyName("activity")]
        public List<string>? Activity { get; set; }

        [AwesomeProperty("availability")]
        [JsonPropertyName("availability")]
        public List<long>? Availability { get; set; }

        [AwesomeProperty("code")]
        [JsonPropertyName("code")]
        public long? Code { get; set; }

        [AwesomeProperty("friendIds")]
        [JsonPropertyName("friendIds")]
        public List<string>? FriendIds { get; set; }

        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [AwesomeProperty("lastSeenAt")]
        [JsonPropertyName("lastSeenAt")]
        public List<string>? LastSeenAt { get; set; }

    }
}