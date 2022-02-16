// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchmakingResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }
        
        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }
        
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
        
        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }
        
        [JsonPropertyName("matching_allies")]
        public List<ModelsMatchingAlly>? MatchingAllies { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("party_attributes")]
        public Dictionary<string, object>? PartyAttributes { get; set; }
        
        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("queued_at")]
        public long? QueuedAt { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("server_name")]
        public string? ServerName { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}