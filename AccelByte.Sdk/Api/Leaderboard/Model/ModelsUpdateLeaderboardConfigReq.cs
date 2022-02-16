// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUpdateLeaderboardConfigReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("daily")]
        public ModelsDailyConfig? Daily { get; set; }
        
        [JsonPropertyName("descending")]
        public bool? Descending { get; set; }
        
        [JsonPropertyName("iconURL")]
        public string? IconURL { get; set; }
        
        [JsonPropertyName("monthly")]
        public ModelsMonthlyConfig? Monthly { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("seasonPeriod")]
        public int? SeasonPeriod { get; set; }
        
        [JsonPropertyName("startTime")]
        public string? StartTime { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("weekly")]
        public ModelsWeeklyConfig? Weekly { get; set; }
        
    }
}