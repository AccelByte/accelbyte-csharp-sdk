// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Match2.Model
{
    public class ApiPatchNamespaceConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("crossPlatformNoCurrentPlatform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CrossPlatformNoCurrentPlatform { get; set; }

        [JsonPropertyName("extraPlatforms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ExtraPlatforms { get; set; }

        [JsonPropertyName("matchAnyCommon")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? MatchAnyCommon { get; set; }

        [JsonPropertyName("platformGroup")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? PlatformGroup { get; set; }

    }


}