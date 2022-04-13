// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsDetailedCountServerResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("busy_count")]
        public int? BusyCount { get; set; }

        [JsonPropertyName("creating_count")]
        public int? CreatingCount { get; set; }

        [JsonPropertyName("ready_count")]
        public int? ReadyCount { get; set; }

        [JsonPropertyName("unreachable_count")]
        public int? UnreachableCount { get; set; }

    }
}