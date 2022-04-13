// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsAdditionalInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("numberOfAchievements")]
        public long? NumberOfAchievements { get; set; }

        [JsonPropertyName("numberOfHiddenAchievements")]
        public long? NumberOfHiddenAchievements { get; set; }

        [JsonPropertyName("numberOfVisibleAchievements")]
        public long? NumberOfVisibleAchievements { get; set; }

    }
}