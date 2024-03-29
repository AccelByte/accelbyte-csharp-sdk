// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsPartyPUTCustomAttributesRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_attribute")]
        public Dictionary<string, object>? CustomAttribute { get; set; }

        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }

    }

    public class ModelsPartyPUTCustomAttributesRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_attribute")]
        public T1? CustomAttribute { get; set; }

        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }

    }

}