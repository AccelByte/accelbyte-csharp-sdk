// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DiscountConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categories")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<DiscountCategory>? Categories { get; set; }

        [JsonPropertyName("currencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencyNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyNamespace { get; set; }

        [JsonPropertyName("discountAmount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DiscountAmount { get; set; }

        [JsonPropertyName("discountPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DiscountPercentage { get; set; }

        [JsonPropertyName("discountType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DiscountConfigDiscountType? DiscountType { get; set; }

        [JsonPropertyName("items")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<DiscountItem>? Items { get; set; }

        [JsonPropertyName("restrictType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DiscountConfigRestrictType? RestrictType { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

    }



    public class DiscountConfigDiscountType : StringEnum<DiscountConfigDiscountType>
    {
        public static readonly DiscountConfigDiscountType AMOUNT
            = new DiscountConfigDiscountType("AMOUNT");

        public static readonly DiscountConfigDiscountType PERCENTAGE
            = new DiscountConfigDiscountType("PERCENTAGE");


        public static implicit operator DiscountConfigDiscountType(string value)
        {
            return NewValue(value);
        }

        public DiscountConfigDiscountType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class DiscountConfigRestrictType : StringEnum<DiscountConfigRestrictType>
    {
        public static readonly DiscountConfigRestrictType ITEMSANDCATEGORIES
            = new DiscountConfigRestrictType("ITEMS_AND_CATEGORIES");

        public static readonly DiscountConfigRestrictType NONE
            = new DiscountConfigRestrictType("NONE");


        public static implicit operator DiscountConfigRestrictType(string value)
        {
            return NewValue(value);
        }

        public DiscountConfigRestrictType(string enumValue)
            : base(enumValue)
        {

        }
    }
}