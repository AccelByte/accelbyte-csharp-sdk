// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsAdminConcurrentRecordRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("set_by")]
        public string? SetBy { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }
        
        [JsonPropertyName("value")]
        public Dictionary<string, object>? Value { get; set; }
        
    }
}