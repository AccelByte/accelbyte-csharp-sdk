// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsDeleteZombieRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("JobCount")]
        public int? JobCount { get; set; }

        [JsonPropertyName("Region")]
        public string? Region { get; set; }

        [JsonPropertyName("TimeoutSecond")]
        public int? TimeoutSecond { get; set; }

        [JsonPropertyName("ZombieCount")]
        public int? ZombieCount { get; set; }

    }


}