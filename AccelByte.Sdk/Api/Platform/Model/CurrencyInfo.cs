// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencyInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonPropertyName("currencyType")]
        [JsonStringEnum]
        public CurrencyInfoCurrencyType? CurrencyType { get; set; }

        [JsonPropertyName("decimals")]
        public int? Decimals { get; set; }

        [JsonPropertyName("localizationDescriptions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? LocalizationDescriptions { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }



    public class CurrencyInfoCurrencyType : StringEnum<CurrencyInfoCurrencyType>
    {
        public static readonly CurrencyInfoCurrencyType REAL
            = new CurrencyInfoCurrencyType("REAL");

        public static readonly CurrencyInfoCurrencyType VIRTUAL
            = new CurrencyInfoCurrencyType("VIRTUAL");


        public static implicit operator CurrencyInfoCurrencyType(string value)
        {
            return NewValue(value);
        }

        public CurrencyInfoCurrencyType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}