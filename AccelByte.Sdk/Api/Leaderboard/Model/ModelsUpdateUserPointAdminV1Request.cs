// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUpdateUserPointAdminV1Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("inc")]
        public double? Inc { get; set; }

        [JsonPropertyName("latestValue")]
        public double? LatestValue { get; set; }

    }
}