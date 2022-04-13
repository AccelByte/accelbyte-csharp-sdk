// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class GoogleIAPReceipt : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("autoAck")]
        public bool? AutoAck { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("orderId")]
        public string? OrderId { get; set; }

        [JsonPropertyName("packageName")]
        public string? PackageName { get; set; }

        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        [JsonPropertyName("purchaseTime")]
        public long? PurchaseTime { get; set; }

        [JsonPropertyName("purchaseToken")]
        public string? PurchaseToken { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

    }
}