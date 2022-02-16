// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class HandlersUserPresence : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("activity")]
        public string? Activity { get; set; }
        
        [JsonPropertyName("availability")]
        public string? Availability { get; set; }
        
        [JsonPropertyName("lastSeenAt")]
        public string? LastSeenAt { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userID")]
        public string? UserID { get; set; }
        
    }
}