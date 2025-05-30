// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Csm.Model
{
    public class GeneratedGetDeploymentListV1Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appIds")]
        public List<string>? AppIds { get; set; }

        [JsonPropertyName("deploymentIds")]
        public List<string>? DeploymentIds { get; set; }

        [JsonPropertyName("statuses")]
        public List<string>? Statuses { get; set; }

    }


}