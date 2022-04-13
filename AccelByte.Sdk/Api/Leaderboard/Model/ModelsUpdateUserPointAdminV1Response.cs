// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUpdateUserPointAdminV1Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("point")]
        public double? Point { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }
}