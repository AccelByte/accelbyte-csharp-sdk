using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsGameSessionSetting : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allow_join_in_progress")]
        public bool? AllowJoinInProgress { get; set; }
        
        [JsonPropertyName("current_internal_player")]
        public int? CurrentInternalPlayer { get; set; }
        
        [JsonPropertyName("current_player")]
        public int? CurrentPlayer { get; set; }
        
        [JsonPropertyName("map_name")]
        public string? MapName { get; set; }
        
        [JsonPropertyName("max_internal_player")]
        public int? MaxInternalPlayer { get; set; }
        
        [JsonPropertyName("max_player")]
        public int? MaxPlayer { get; set; }
        
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }
        
        [JsonPropertyName("num_bot")]
        public int? NumBot { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
        [JsonPropertyName("settings")]
        public Dictionary<object, object>? Settings { get; set; }
        
    }
}