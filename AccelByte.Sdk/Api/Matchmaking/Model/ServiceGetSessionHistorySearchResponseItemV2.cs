// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ServiceGetSessionHistorySearchResponseItemV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("_id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}