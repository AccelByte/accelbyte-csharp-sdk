// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleV4Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("adminRole")]
        public bool? AdminRole { get; set; }

        [JsonPropertyName("deletable")]
        public bool? Deletable { get; set; }

        [JsonPropertyName("isWildcard")]
        public bool? IsWildcard { get; set; }

        [JsonPropertyName("roleName")]
        public string? RoleName { get; set; }

    }
}