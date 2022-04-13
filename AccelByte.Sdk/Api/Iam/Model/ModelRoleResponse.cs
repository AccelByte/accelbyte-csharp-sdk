// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("IsWildcard")]
        public bool? IsWildcard { get; set; }

        [JsonPropertyName("Permissions")]
        public List<AccountcommonPermission>? Permissions { get; set; }

        [JsonPropertyName("RoleId")]
        public string? RoleId { get; set; }

        [JsonPropertyName("RoleName")]
        public string? RoleName { get; set; }

    }
}