// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGroupResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configurationCode")]
        public string? ConfigurationCode { get; set; }

        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }

        [JsonPropertyName("groupDescription")]
        public string? GroupDescription { get; set; }

        [JsonPropertyName("groupIcon")]
        public string? GroupIcon { get; set; }

        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }

        [JsonPropertyName("groupMaxMember")]
        public int? GroupMaxMember { get; set; }

        [JsonPropertyName("groupMembers")]
        public List<ModelsGroupMember>? GroupMembers { get; set; }

        [JsonPropertyName("groupName")]
        public string? GroupName { get; set; }

        [JsonPropertyName("groupRegion")]
        public string? GroupRegion { get; set; }

        [JsonPropertyName("groupRules")]
        public ModelsGroupRule? GroupRules { get; set; }

        [JsonPropertyName("groupType")]
        public string? GroupType { get; set; }

    }
}