// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserBanResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Ban")]
        public string? Ban { get; set; }

        [JsonPropertyName("BanId")]
        public string? BanId { get; set; }

        [JsonPropertyName("BannedBy")]
        public BannedBy? BannedBy { get; set; }

        [JsonPropertyName("Comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("DisabledDate")]
        public DateTime? DisabledDate { get; set; }

        [JsonPropertyName("Enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("EndDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("Reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }

    }
}