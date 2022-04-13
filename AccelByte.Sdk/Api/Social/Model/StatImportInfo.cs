// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatImportInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failedConfigs")]
        public List<string>? FailedConfigs { get; set; }

        [JsonPropertyName("ignoredConfigs")]
        public List<string>? IgnoredConfigs { get; set; }

        [JsonPropertyName("newConfigs")]
        public List<string>? NewConfigs { get; set; }

        [JsonPropertyName("replacedConfigs")]
        public List<string>? ReplacedConfigs { get; set; }

    }
}