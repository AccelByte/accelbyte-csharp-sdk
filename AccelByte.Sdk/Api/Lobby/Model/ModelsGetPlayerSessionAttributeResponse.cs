// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsGetPlayerSessionAttributeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
    }
}