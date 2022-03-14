// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AdyenConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedPaymentMethods")]
        public List<string>? AllowedPaymentMethods { get; set; }
        
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
        [JsonPropertyName("authoriseAsCapture")]
        public bool? AuthoriseAsCapture { get; set; }
        
        [JsonPropertyName("blockedPaymentMethods")]
        public List<string>? BlockedPaymentMethods { get; set; }
        
        [JsonPropertyName("clientKey")]
        public string? ClientKey { get; set; }
        
        [JsonPropertyName("dropInSettings")]
        public string? DropInSettings { get; set; }
        
        [JsonPropertyName("liveEndpointUrlPrefix")]
        public string? LiveEndpointUrlPrefix { get; set; }
        
        [JsonPropertyName("merchantAccount")]
        public string? MerchantAccount { get; set; }
        
        [JsonPropertyName("notificationHmacKey")]
        public string? NotificationHmacKey { get; set; }
        
        [JsonPropertyName("notificationPassword")]
        public string? NotificationPassword { get; set; }
        
        [JsonPropertyName("notificationUsername")]
        public string? NotificationUsername { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
        [JsonPropertyName("settings")]
        public string? Settings { get; set; }
        
    }
}