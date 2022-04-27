// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventRegistry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventID")]
        public int? EventID { get; set; }

        [JsonPropertyName("EventLevel")]
        public int? EventLevel { get; set; }

        [JsonPropertyName("EventType")]
        public int? EventType { get; set; }

        [JsonPropertyName("UX")]
        public int? UX { get; set; }

    }
}