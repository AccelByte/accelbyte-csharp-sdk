// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencySummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonPropertyName("currencyType")]
        [JsonStringEnum]
        public CurrencySummaryCurrencyType? CurrencyType { get; set; }

        [JsonPropertyName("decimals")]
        public int? Decimals { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

    }

    public class CurrencySummaryCurrencyType : StringEnum<CurrencySummaryCurrencyType>
    {
        public static readonly CurrencySummaryCurrencyType REAL
            = new CurrencySummaryCurrencyType("REAL");

        public static readonly CurrencySummaryCurrencyType VIRTUAL
            = new CurrencySummaryCurrencyType("VIRTUAL");


        public static implicit operator CurrencySummaryCurrencyType(string value)
        {
            return Create(value);
        }

        public CurrencySummaryCurrencyType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}