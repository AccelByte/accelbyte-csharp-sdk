// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelGetUserFriendsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("friendIDs")]
        public List<string>? FriendIDs { get; set; }

        [JsonPropertyName("paging")]
        public ModelPagination? Paging { get; set; }

    }
}