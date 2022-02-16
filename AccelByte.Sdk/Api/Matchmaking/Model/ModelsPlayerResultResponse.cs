// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsPlayerResultResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("current_score")]
        public List<ModelsResultAttributeResponse>? CurrentScore { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}