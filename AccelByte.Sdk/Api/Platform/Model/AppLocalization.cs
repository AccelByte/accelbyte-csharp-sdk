// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppLocalization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("announcement")]
        public string? Announcement { get; set; }
        
        [JsonPropertyName("slogan")]
        public string? Slogan { get; set; }
        
    }
}