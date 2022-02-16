// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProcessResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("pending")]
        public bool? Pending { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
        [JsonPropertyName("redirectUrl")]
        public string? RedirectUrl { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}