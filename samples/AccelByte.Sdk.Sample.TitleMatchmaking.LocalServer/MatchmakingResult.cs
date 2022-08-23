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

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class MatchmakingResult
    {
        [JsonPropertyName("is_first_member")]
        public bool IsFirstMember { get; set; } = false;

        [JsonPropertyName("message")]
        public string Message { get; set; } = String.Empty;

        [JsonPropertyName("party_id")]
        public string PartyId { get; set; } = String.Empty;

        [JsonPropertyName("server_ip")]
        public string ServerIp { get; set; } = String.Empty;

        [JsonPropertyName("server_port")]
        public int ServerPort { get; set; } = 0;

        [JsonPropertyName("session_id")]
        public string SessionId { get; set; } = String.Empty;

        [JsonPropertyName("users")]
        public List<string> Users { get; set; } = new List<string>();
    }
}