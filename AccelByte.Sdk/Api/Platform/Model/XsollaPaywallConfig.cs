// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XsollaPaywallConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("device")]
        public string? Device { get; set; }
        
        [JsonPropertyName("showCloseButton")]
        public bool? ShowCloseButton { get; set; }
        
        [JsonPropertyName("size")]
        public string? Size { get; set; }
        
        [JsonPropertyName("theme")]
        public string? Theme { get; set; }
        
    }
}