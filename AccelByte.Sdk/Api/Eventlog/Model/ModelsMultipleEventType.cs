// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsMultipleEventType : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventType")]
        public List<ModelsEventType>? EventType { get; set; }

    }


}