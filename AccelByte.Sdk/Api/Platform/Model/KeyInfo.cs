// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acquireOrderNo")]
        public string? AcquireOrderNo { get; set; }
        
        [JsonPropertyName("acquireUserId")]
        public string? AcquireUserId { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("keyFile")]
        public string? KeyFile { get; set; }
        
        [JsonPropertyName("keyGroupId")]
        public string? KeyGroupId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
    }
}