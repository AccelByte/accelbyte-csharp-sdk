// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelTokenResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        [JsonPropertyName("bans")]
        public List<AccountcommonJWTBanV3>? Bans { get; set; }

        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        [JsonPropertyName("is_comply")]
        public bool? IsComply { get; set; }

        [JsonPropertyName("jflgs")]
        public int? Jflgs { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("namespace_roles")]
        public List<AccountcommonNamespaceRole>? NamespaceRoles { get; set; }

        [JsonPropertyName("permissions")]
        public List<AccountcommonPermission>? Permissions { get; set; }

        [JsonPropertyName("platform_id")]
        public string? PlatformId { get; set; }

        [JsonPropertyName("platform_user_id")]
        public string? PlatformUserId { get; set; }

        [JsonPropertyName("refresh_expires_in")]
        public int? RefreshExpiresIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }

        [JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }
}