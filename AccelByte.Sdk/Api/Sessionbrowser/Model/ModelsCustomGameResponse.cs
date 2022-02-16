// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsCustomGameResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("all_players")]
        public List<string>? AllPlayers { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("game_session_setting")]
        public ModelsGameSessionSetting? GameSessionSetting { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("players")]
        public List<string>? Players { get; set; }
        
        [JsonPropertyName("server")]
        public ModelsServer? Server { get; set; }
        
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
        
        [JsonPropertyName("session_type")]
        public string? SessionType { get; set; }
        
        [JsonPropertyName("spectators")]
        public List<string>? Spectators { get; set; }
        
    }
}