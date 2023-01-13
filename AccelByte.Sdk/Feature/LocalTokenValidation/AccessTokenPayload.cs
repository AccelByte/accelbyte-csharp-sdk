// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IdentityModel.Tokens.Jwt;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class AccessTokenPayload
    {
        public class Types
        {
            public class Role
            {
                [JsonPropertyName("Namespace")]
                public string Namespace { get; set; } = String.Empty;

                [JsonPropertyName("RoleId")]
                public string RoleId { get; set; } = String.Empty;
            }

            public class Permission
            {
                [JsonPropertyName("Action")]
                public int Action { get; set; } = 0;

                [JsonPropertyName("Resource")]
                public string Resource { get; set; } = String.Empty;
            }
        }

        [JsonPropertyName("bans")]
        public List<AccountcommonJWTBanV3>? Bans { get; set; }

        [JsonPropertyName("client_id")]
        public string? ClientId { get; set; } = null;

        [JsonPropertyName("country")]
        public string? Country { get; set; } = null;

        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; } = null;

        [JsonPropertyName("exp")]
        public int? Exp { get; set; } = null;

        [JsonPropertyName("iat")]
        public int? Iat { get; set; } = null;

        [JsonPropertyName("is_comply")]
        public bool? IsComply { get; set; } = null;

        [JsonPropertyName("iss")]
        public string? Iss { get; set; } = null;

        [JsonPropertyName("jflgs")]
        public int? Jflgs { get; set; } = null;

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; } = null;

        [JsonPropertyName("namespace_roles")]
        public List<Types.Role>? NamespaceRoles { get; set; }

        [JsonPropertyName("permissions")]
        public List<Types.Permission>? Permissions { get; set; }

        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }

        [JsonPropertyName("scope")]
        public string? Scope { get; set; } = null;

        public static AccessTokenPayload FromToken(JwtSecurityToken token)
        {
            string snPayload = (token.RawPayload.Length % 4 == 0 ? token.RawPayload : token.RawPayload + "====".Substring(token.RawPayload.Length % 4));
            string payload = Encoding.UTF8.GetString(Convert.FromBase64String(snPayload));
            AccessTokenPayload? obj = JsonSerializer.Deserialize<AccessTokenPayload>(payload, new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                ReadCommentHandling = JsonCommentHandling.Skip
            });

            if (obj == null)
                throw new Exception("Could not deserialize access token payload.");
            return obj;
        }
    }
}