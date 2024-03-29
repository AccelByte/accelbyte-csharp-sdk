// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsSubGameMode : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alliance")]
        public ModelsAllianceRule? Alliance { get; set; }

        [JsonPropertyName("alliance_flexing_rule")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsAllianceFlexingRule>? AllianceFlexingRule { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

    }


}