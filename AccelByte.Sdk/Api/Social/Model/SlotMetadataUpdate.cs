// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class SlotMetadataUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttribute")]
        public string? CustomAttribute { get; set; }
        
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}