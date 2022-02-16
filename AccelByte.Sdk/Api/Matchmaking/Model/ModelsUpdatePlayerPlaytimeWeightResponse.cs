// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsUpdatePlayerPlaytimeWeightResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("playtime")]
        public string? Playtime { get; set; }
        
        [JsonPropertyName("userID")]
        public string? UserID { get; set; }
        
        [JsonPropertyName("weight")]
        public double? Weight { get; set; }
        
    }
}