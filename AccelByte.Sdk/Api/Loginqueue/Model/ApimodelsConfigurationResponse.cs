// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Loginqueue.Model
{
    public class ApimodelsConfigurationResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("maxConcurrency")]
        public int? MaxConcurrency { get; set; }

        [JsonPropertyName("maxLoginRate")]
        public int? MaxLoginRate { get; set; }

        [JsonPropertyName("minActivationPeriodInSecond")]
        public int? MinActivationPeriodInSecond { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("playerPollingTimeInSecond")]
        public int? PlayerPollingTimeInSecond { get; set; }

        [JsonPropertyName("playerReconnectGracePeriodInSecond")]
        public int? PlayerReconnectGracePeriodInSecond { get; set; }

        [JsonPropertyName("queueReconnectGracePeriodInSecond")]
        public int? QueueReconnectGracePeriodInSecond { get; set; }

        [JsonPropertyName("safetyMarginPercentage")]
        public int? SafetyMarginPercentage { get; set; }

    }


}