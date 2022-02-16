// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreateSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }
        
        [JsonPropertyName("configuration")]
        public string? Configuration { get; set; }
        
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
        
        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }
        
        [JsonPropertyName("matching_allies")]
        public List<ModelsRequestMatchingAlly>? MatchingAllies { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
        
    }
}