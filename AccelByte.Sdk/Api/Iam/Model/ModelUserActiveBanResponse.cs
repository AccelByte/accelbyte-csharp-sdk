// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserActiveBanResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Ban")]
        public string? Ban { get; set; }

        [JsonPropertyName("BanId")]
        public string? BanId { get; set; }

        [JsonPropertyName("EndDate")]
        public DateTime? EndDate { get; set; }

    }
}