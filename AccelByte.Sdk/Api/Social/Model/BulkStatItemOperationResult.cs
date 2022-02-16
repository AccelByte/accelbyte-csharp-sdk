// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkStatItemOperationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("details")]
        public Dictionary<string, object>? Details { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}