// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsUserAchievementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("achievedAt")]
        public DateTime? AchievedAt { get; set; }
        
        [JsonPropertyName("achievementCode")]
        public string? AchievementCode { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("latestValue")]
        public double? LatestValue { get; set; }
        
        [JsonPropertyName("name")]
        public Dictionary<string, string>? Name { get; set; }
        
        [JsonPropertyName("status")]
        public int? Status { get; set; }
        
    }
}