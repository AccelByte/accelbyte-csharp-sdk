// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StripeConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedPaymentMethodTypes")]
        public List<string>? AllowedPaymentMethodTypes { get; set; }
        
        [JsonPropertyName("publishableKey")]
        public string? PublishableKey { get; set; }
        
        [JsonPropertyName("secretKey")]
        public string? SecretKey { get; set; }
        
        [JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }
        
    }
}