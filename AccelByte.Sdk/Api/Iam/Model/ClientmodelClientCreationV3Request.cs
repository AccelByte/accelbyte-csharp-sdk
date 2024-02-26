// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientCreationV3Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("audiences")]
        public List<string>? Audiences { get; set; }

        [JsonPropertyName("baseUri")]
        public string? BaseUri { get; set; }

        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        [JsonPropertyName("clientName")]
        public string? ClientName { get; set; }

        [JsonPropertyName("clientPermissions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<AccountcommonPermissionV3>? ClientPermissions { get; set; }

        [JsonPropertyName("clientPlatform")]
        public string? ClientPlatform { get; set; }

        [JsonPropertyName("deletable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deletable { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("modulePermissions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<AccountcommonClientModulePermission>? ModulePermissions { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("oauthAccessTokenExpiration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? OauthAccessTokenExpiration { get; set; }

        [JsonPropertyName("oauthAccessTokenExpirationTimeUnit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OauthAccessTokenExpirationTimeUnit { get; set; }

        [JsonPropertyName("oauthClientType")]
        public string? OauthClientType { get; set; }

        [JsonPropertyName("oauthRefreshTokenExpiration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? OauthRefreshTokenExpiration { get; set; }

        [JsonPropertyName("oauthRefreshTokenExpirationTimeUnit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OauthRefreshTokenExpirationTimeUnit { get; set; }

        [JsonPropertyName("parentNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ParentNamespace { get; set; }

        [JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }

        [JsonPropertyName("scopes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Scopes { get; set; }

        [JsonPropertyName("secret")]
        public string? Secret { get; set; }

        [JsonPropertyName("skipLoginQueue")]
        public bool? SkipLoginQueue { get; set; }

        [JsonPropertyName("twoFactorEnabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TwoFactorEnabled { get; set; }

    }


}