// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("First")]
        public string? First { get; set; }
        
        [JsonPropertyName("Last")]
        public string? Last { get; set; }
        
        [JsonPropertyName("Next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("Previous")]
        public string? Previous { get; set; }
        
    }
}