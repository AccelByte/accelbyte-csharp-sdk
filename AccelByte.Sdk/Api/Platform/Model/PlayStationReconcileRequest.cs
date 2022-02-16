// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlayStationReconcileRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("price")]
        public double? Price { get; set; }
        
        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }
        
        [JsonPropertyName("serviceLabel")]
        public int? ServiceLabel { get; set; }
        
    }
}