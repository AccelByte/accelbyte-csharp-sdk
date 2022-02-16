// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformDlcEntry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platform")]
        public string? Platform { get; set; }
        
        [JsonPropertyName("platformDlcIdMap")]
        public Dictionary<string, string>? PlatformDlcIdMap { get; set; }
        
    }
}