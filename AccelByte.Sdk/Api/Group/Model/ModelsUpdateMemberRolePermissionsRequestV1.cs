// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateMemberRolePermissionsRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("memberRolePermissions")]
        public List<ModelsRolePermission>? MemberRolePermissions { get; set; }
        
    }
}