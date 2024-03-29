// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserLinkedPlatform : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DisplayName { get; set; }

        [JsonPropertyName("EmailAddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("LinkedAt")]
        public string? LinkedAt { get; set; }

        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("OriginNamespace")]
        public string? OriginNamespace { get; set; }

        [JsonPropertyName("PlatformId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PlatformId { get; set; }

        [JsonPropertyName("PlatformUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PlatformUserId { get; set; }

        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }

        [JsonPropertyName("XUID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? XUID { get; set; }

    }


}