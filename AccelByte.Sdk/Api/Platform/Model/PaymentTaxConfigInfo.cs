// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentTaxConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("sandboxTaxJarApiToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SandboxTaxJarApiToken { get; set; }

        [JsonPropertyName("taxJarApiToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TaxJarApiToken { get; set; }

        [JsonPropertyName("taxJarEnabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TaxJarEnabled { get; set; }

        [JsonPropertyName("taxJarProductCodesMapping")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? TaxJarProductCodesMapping { get; set; }

    }


}