// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderRefundResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }
        
        [JsonPropertyName("refundedTime")]
        public DateTime? RefundedTime { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }
        
        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }
        
    }
}