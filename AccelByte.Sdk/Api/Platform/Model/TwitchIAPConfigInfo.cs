// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TwitchIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }
        
    }
}