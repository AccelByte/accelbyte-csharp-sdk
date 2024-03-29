// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsCustomFunction : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("afterBulkReadGameBinaryRecord")]
        public bool? AfterBulkReadGameBinaryRecord { get; set; }

        [JsonPropertyName("afterBulkReadGameRecord")]
        public bool? AfterBulkReadGameRecord { get; set; }

        [JsonPropertyName("afterBulkReadPlayerBinaryRecord")]
        public bool? AfterBulkReadPlayerBinaryRecord { get; set; }

        [JsonPropertyName("afterBulkReadPlayerRecord")]
        public bool? AfterBulkReadPlayerRecord { get; set; }

        [JsonPropertyName("afterReadGameBinaryRecord")]
        public bool? AfterReadGameBinaryRecord { get; set; }

        [JsonPropertyName("afterReadGameRecord")]
        public bool? AfterReadGameRecord { get; set; }

        [JsonPropertyName("afterReadPlayerBinaryRecord")]
        public bool? AfterReadPlayerBinaryRecord { get; set; }

        [JsonPropertyName("afterReadPlayerRecord")]
        public bool? AfterReadPlayerRecord { get; set; }

        [JsonPropertyName("beforeWriteAdminGameRecord")]
        public bool? BeforeWriteAdminGameRecord { get; set; }

        [JsonPropertyName("beforeWriteAdminPlayerRecord")]
        public bool? BeforeWriteAdminPlayerRecord { get; set; }

        [JsonPropertyName("beforeWriteGameBinaryRecord")]
        public bool? BeforeWriteGameBinaryRecord { get; set; }

        [JsonPropertyName("beforeWriteGameRecord")]
        public bool? BeforeWriteGameRecord { get; set; }

        [JsonPropertyName("beforeWritePlayerBinaryRecord")]
        public bool? BeforeWritePlayerBinaryRecord { get; set; }

        [JsonPropertyName("beforeWritePlayerRecord")]
        public bool? BeforeWritePlayerRecord { get; set; }

    }


}