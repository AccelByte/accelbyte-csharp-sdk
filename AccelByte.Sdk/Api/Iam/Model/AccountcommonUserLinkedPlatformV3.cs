// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserLinkedPlatformV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("accountGroup")]
        public string? AccountGroup { get; set; }

        [JsonPropertyName("displayName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DisplayName { get; set; }

        [JsonPropertyName("emailAddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("linkedAt")]
        public string? LinkedAt { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("originNamespace")]
        public string? OriginNamespace { get; set; }

        [JsonPropertyName("platformId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PlatformId { get; set; }

        [JsonPropertyName("platformUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PlatformUserId { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


}