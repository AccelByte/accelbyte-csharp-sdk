// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsServer : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allocation_id")]
        public string? AllocationId { get; set; }
        
        [JsonPropertyName("alternate_ips")]
        public List<string>? AlternateIps { get; set; }
        
        [JsonPropertyName("cpu_limit")]
        public int? CpuLimit { get; set; }
        
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
        
        [JsonPropertyName("game_version")]
        public string? GameVersion { get; set; }
        
        [JsonPropertyName("image_version")]
        public string? ImageVersion { get; set; }
        
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }
        
        [JsonPropertyName("last_update")]
        public DateTime? LastUpdate { get; set; }
        
        [JsonPropertyName("mem_limit")]
        public int? MemLimit { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("params")]
        public string? Params { get; set; }
        
        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }
        
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
        [JsonPropertyName("ports")]
        public Dictionary<string, long>? Ports { get; set; }
        
        [JsonPropertyName("provider")]
        public string? Provider { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("status_history")]
        public List<ModelsStatusHistory>? StatusHistory { get; set; }
        
    }
}