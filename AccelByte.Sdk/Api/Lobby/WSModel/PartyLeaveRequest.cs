// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("partyLeaveRequest")]
    public class PartyLeaveRequest : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [AwesomeProperty("ignoreUserRegistry")]
        [JsonPropertyName("ignoreUserRegistry")]
        public bool? IgnoreUserRegistry { get; set; }
        
    }
}