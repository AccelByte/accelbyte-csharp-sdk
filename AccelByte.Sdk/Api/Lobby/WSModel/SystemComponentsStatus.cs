// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("systemComponentsStatus")]
    public class SystemComponentsStatus : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("components")]
        [JsonPropertyName("components")]
        public Dictionary<string, bool>? Components { get; set; }
        
    }
}