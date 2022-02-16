// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("Previous")]
        public string? Previous { get; set; }
        
    }
}