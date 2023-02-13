// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateGroupConfigurationResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowMultiple")]
        public bool? AllowMultiple { get; set; }

        [JsonPropertyName("configurationCode")]
        public string? ConfigurationCode { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("globalRules")]
        public List<ModelsRuleResponseV1>? GlobalRules { get; set; }

        [JsonPropertyName("groupAdminRoleId")]
        public string? GroupAdminRoleId { get; set; }

        [JsonPropertyName("groupMaxMember")]
        public int? GroupMaxMember { get; set; }

        [JsonPropertyName("groupMemberRoleId")]
        public string? GroupMemberRoleId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

    }


}