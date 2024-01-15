// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelTokenThirdPartyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PlatformUserId { get; set; }

        [JsonPropertyName("platform_token")]
        public string? PlatformToken { get; set; }

        [JsonPropertyName("platform_token_expires_at")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? PlatformTokenExpiresAt { get; set; }

        [JsonPropertyName("sand_box_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SandBoxId { get; set; }

    }


}