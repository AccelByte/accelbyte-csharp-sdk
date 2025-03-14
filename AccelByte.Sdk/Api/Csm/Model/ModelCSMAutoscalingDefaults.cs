// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Csm.Model
{
    public class ModelCSMAutoscalingDefaults : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cpuUtilizationDefaultPercent")]
        public int? CpuUtilizationDefaultPercent { get; set; }

        [JsonPropertyName("cpuUtilizationMaxPercent")]
        public int? CpuUtilizationMaxPercent { get; set; }

        [JsonPropertyName("cpuUtilizationMinPercent")]
        public int? CpuUtilizationMinPercent { get; set; }

    }


}