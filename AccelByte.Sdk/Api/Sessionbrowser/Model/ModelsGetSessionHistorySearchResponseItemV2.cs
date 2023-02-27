// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsGetSessionHistorySearchResponseItemV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("_id")]
        public string? Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }

        [JsonPropertyName("joining")]
        public List<ModelsSessionPlayerJoining>? Joining { get; set; }

        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("players")]
        public List<ModelsSessionPlayerHistory>? Players { get; set; }

        [JsonPropertyName("removed_reason")]
        public string? RemovedReason { get; set; }

        [JsonPropertyName("session_type")]
        public string? SessionType { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("sub_game_mode")]
        public List<string>? SubGameMode { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }


}