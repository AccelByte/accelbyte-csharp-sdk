// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CampaignDynamicInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableSaleCount")]
        public int? AvailableSaleCount { get; set; }

        [JsonPropertyName("lastBatchNo")]
        public int? LastBatchNo { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("remainder")]
        public int? Remainder { get; set; }

        [JsonPropertyName("saleCount")]
        public int? SaleCount { get; set; }

    }
}