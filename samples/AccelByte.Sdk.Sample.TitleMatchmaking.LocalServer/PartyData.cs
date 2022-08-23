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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class PartyData
    {
        [JsonPropertyName("channel")]
        public string Channel { get; set; } = String.Empty;

        [JsonPropertyName("client_version")]
        public string ClientVersion { get; set; } = String.Empty;

        [JsonPropertyName("party_id")]
        public string PartyId { get; set; } = String.Empty;

        [JsonPropertyName("party_members")]
        public List<ModelsPartyMember>? PartyMembers { get; set; } = null;

        [JsonPropertyName("priority")]
        public int Priority { get; set; } = 0;

        [JsonPropertyName("server_name")]
        public string ServerName { get; set; } = String.Empty;

        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = String.Empty;
    }
}