// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProviderConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("aggregate")]
        public string? Aggregate { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("paymentMerchantConfigId")]
        public string? PaymentMerchantConfigId { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("sandboxTaxJarApiToken")]
        public string? SandboxTaxJarApiToken { get; set; }
        
        [JsonPropertyName("specials")]
        public List<string>? Specials { get; set; }
        
        [JsonPropertyName("taxJarApiToken")]
        public string? TaxJarApiToken { get; set; }
        
        [JsonPropertyName("taxJarEnabled")]
        public bool? TaxJarEnabled { get; set; }
        
        [JsonPropertyName("useGlobalTaxJarApiToken")]
        public bool? UseGlobalTaxJarApiToken { get; set; }
        
    }
}