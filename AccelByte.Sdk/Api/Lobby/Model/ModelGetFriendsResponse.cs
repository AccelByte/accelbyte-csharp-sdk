// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelGetFriendsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("friendIDs")]
        public List<string>? FriendIDs { get; set; }

        [JsonPropertyName("friendsSinceTimes")]
        public List<string>? FriendsSinceTimes { get; set; }

        [JsonPropertyName("paging")]
        public ModelPagination? Paging { get; set; }

    }


}