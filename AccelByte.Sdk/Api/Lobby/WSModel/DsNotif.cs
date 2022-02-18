// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("dsNotif")]
    public class DsNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("podName")]
        [JsonPropertyName("podName")]
        public string? PodName { get; set; }
        
        [AwesomeProperty("imageVersion")]
        [JsonPropertyName("imageVersion")]
        public string? ImageVersion { get; set; }
        
        [AwesomeProperty("namespace")]
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [AwesomeProperty("ip")]
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }
        
        [AwesomeProperty("alternateIps")]
        [JsonPropertyName("alternateIps")]
        public List<string>? AlternateIps { get; set; }
        
        [AwesomeProperty("port")]
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
        [AwesomeProperty("protocol")]
        [JsonPropertyName("protocol")]
        public string? Protocol { get; set; }
        
        [AwesomeProperty("ports")]
        [JsonPropertyName("ports")]
        public Dictionary<string, int>? Ports { get; set; }
        
        [AwesomeProperty("provider")]
        [JsonPropertyName("provider")]
        public string? Provider { get; set; }
        
        [AwesomeProperty("gameVersion")]
        [JsonPropertyName("gameVersion")]
        public string? GameVersion { get; set; }
        
        [AwesomeProperty("status")]
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [AwesomeProperty("lastUpdate")]
        [JsonPropertyName("lastUpdate")]
        public string? LastUpdate { get; set; }
        
        [AwesomeProperty("sessionId")]
        [JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }
        
        [AwesomeProperty("deployment")]
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
        
        [AwesomeProperty("region")]
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [AwesomeProperty("isOverrideGameVersion")]
        [JsonPropertyName("isOverrideGameVersion")]
        public bool? IsOverrideGameVersion { get; set; }
        
        [AwesomeProperty("customAttribute")]
        [JsonPropertyName("customAttribute")]
        public string? CustomAttribute { get; set; }
        
        [AwesomeProperty("matchId")]
        [JsonPropertyName("matchId")]
        public string? MatchId { get; set; }
        
        [AwesomeProperty("isOK")]
        [JsonPropertyName("isOK")]
        public bool? IsOK { get; set; }
        
        [AwesomeProperty("message")]
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
    }
}