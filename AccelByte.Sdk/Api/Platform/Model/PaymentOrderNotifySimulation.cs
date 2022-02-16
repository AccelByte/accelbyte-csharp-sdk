// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderNotifySimulation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }
        
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("notifyType")]
        public string? NotifyType { get; set; }
        
        [JsonPropertyName("paymentProvider")]
        public string? PaymentProvider { get; set; }
        
        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }
        
        [JsonPropertyName("vat")]
        public int? Vat { get; set; }
        
    }
}