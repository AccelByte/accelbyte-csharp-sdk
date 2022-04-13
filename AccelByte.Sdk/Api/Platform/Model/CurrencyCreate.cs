// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencyCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonPropertyName("currencyType")]
        [JsonStringEnum]
        public CurrencyCreateCurrencyType? CurrencyType { get; set; }

        [JsonPropertyName("decimals")]
        public int? Decimals { get; set; }

        [JsonPropertyName("localizationDescriptions")]
        public Dictionary<string, string>? LocalizationDescriptions { get; set; }

    }

    public class CurrencyCreateCurrencyType : StringEnum<CurrencyCreateCurrencyType>
    {
        public static readonly CurrencyCreateCurrencyType REAL
            = new CurrencyCreateCurrencyType("REAL");

        public static readonly CurrencyCreateCurrencyType VIRTUAL
            = new CurrencyCreateCurrencyType("VIRTUAL");


        public static implicit operator CurrencyCreateCurrencyType(string value)
        {
            return Create(value);
        }

        public CurrencyCreateCurrencyType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}