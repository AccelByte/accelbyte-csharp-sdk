// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Csm.Model
{
    public class ApimodelCSMAppLimitsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("autoscaling")]
        public ModelCSMAutoscalingDefaults? Autoscaling { get; set; }

        [JsonPropertyName("extendAppCPULimit")]
        public int? ExtendAppCPULimit { get; set; }

        [JsonPropertyName("extendAppEventHandlerCPULimit")]
        public int? ExtendAppEventHandlerCPULimit { get; set; }

        [JsonPropertyName("extendAppMemoryLimit")]
        public int? ExtendAppMemoryLimit { get; set; }

        [JsonPropertyName("extendAppReplicaLimit")]
        public int? ExtendAppReplicaLimit { get; set; }

        [JsonPropertyName("extendAppeEventHandlerMemoryLimit")]
        public int? ExtendAppeEventHandlerMemoryLimit { get; set; }

        [JsonPropertyName("maxSubscriberCount")]
        public int? MaxSubscriberCount { get; set; }

    }


}