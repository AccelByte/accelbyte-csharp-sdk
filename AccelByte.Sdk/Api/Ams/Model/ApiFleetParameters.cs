// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiFleetParameters : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("claimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ClaimKeys { get; set; }

        [JsonPropertyName("dsHostConfiguration")]
        public ApiDSHostConfiguration? DsHostConfiguration { get; set; }

        [JsonPropertyName("imageDeploymentProfile")]
        public ApiImageDeploymentProfile? ImageDeploymentProfile { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("regions")]
        public List<ApiRegionConfig>? Regions { get; set; }

        [JsonPropertyName("samplingRules")]
        public ApiFleetArtifactsSampleRules? SamplingRules { get; set; }

    }


}