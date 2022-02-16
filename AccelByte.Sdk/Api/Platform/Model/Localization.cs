// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Localization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("localExt")]
        public Dictionary<string, object>? LocalExt { get; set; }
        
        [JsonPropertyName("longDescription")]
        public string? LongDescription { get; set; }
        
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        
    }
}