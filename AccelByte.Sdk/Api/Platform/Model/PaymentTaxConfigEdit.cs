// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentTaxConfigEdit : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("sandboxTaxJarApiToken")]
        public string? SandboxTaxJarApiToken { get; set; }
        
        [JsonPropertyName("taxJarApiToken")]
        public string? TaxJarApiToken { get; set; }
        
        [JsonPropertyName("taxJarEnabled")]
        public bool? TaxJarEnabled { get; set; }
        
        [JsonPropertyName("taxJarProductCodesMapping")]
        public Dictionary<string, string>? TaxJarProductCodesMapping { get; set; }
        
    }
}