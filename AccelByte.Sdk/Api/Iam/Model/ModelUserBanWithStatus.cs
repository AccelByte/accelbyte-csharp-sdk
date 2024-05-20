// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserBanWithStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("ban")]
        public string? Ban { get; set; }

        [JsonPropertyName("banId")]
        public string? BanId { get; set; }

        [JsonPropertyName("bannedBy")]
        public AccountcommonBannedByV3? BannedBy { get; set; }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("disabledDate")]
        public DateTime? DisabledDate { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


}