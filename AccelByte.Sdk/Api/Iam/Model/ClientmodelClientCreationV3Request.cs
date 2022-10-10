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
        public List<AccountcommonPermissionV3>? ClientPermissions { get; set; }

        [JsonPropertyName("clientPlatform")]
        public string? ClientPlatform { get; set; }

        [JsonPropertyName("deletable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deletable { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("oauthClientType")]
        public string? OauthClientType { get; set; }

        [JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }

        [JsonPropertyName("secret")]
        public string? Secret { get; set; }

        [JsonPropertyName("twoFactorEnabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TwoFactorEnabled { get; set; }

    }
}