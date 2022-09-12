// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemTypeConfigCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("dryRun")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DryRun { get; set; }

        [JsonPropertyName("fulfillmentUrl")]
        public string? FulfillmentUrl { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemTypeConfigCreateItemType? ItemType { get; set; }

        [JsonPropertyName("purchaseConditionUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PurchaseConditionUrl { get; set; }

    }

    public class ItemTypeConfigCreateItemType : StringEnum<ItemTypeConfigCreateItemType>
    {
        public static readonly ItemTypeConfigCreateItemType APP
            = new ItemTypeConfigCreateItemType("APP");

        public static readonly ItemTypeConfigCreateItemType BUNDLE
            = new ItemTypeConfigCreateItemType("BUNDLE");

        public static readonly ItemTypeConfigCreateItemType CODE
            = new ItemTypeConfigCreateItemType("CODE");

        public static readonly ItemTypeConfigCreateItemType COINS
            = new ItemTypeConfigCreateItemType("COINS");

        public static readonly ItemTypeConfigCreateItemType EXTENSION
            = new ItemTypeConfigCreateItemType("EXTENSION");

        public static readonly ItemTypeConfigCreateItemType INGAMEITEM
            = new ItemTypeConfigCreateItemType("INGAMEITEM");

        public static readonly ItemTypeConfigCreateItemType MEDIA
            = new ItemTypeConfigCreateItemType("MEDIA");

        public static readonly ItemTypeConfigCreateItemType OPTIONBOX
            = new ItemTypeConfigCreateItemType("OPTIONBOX");

        public static readonly ItemTypeConfigCreateItemType SEASON
            = new ItemTypeConfigCreateItemType("SEASON");

        public static readonly ItemTypeConfigCreateItemType SUBSCRIPTION
            = new ItemTypeConfigCreateItemType("SUBSCRIPTION");


        public static implicit operator ItemTypeConfigCreateItemType(string value)
        {
            return NewValue(value);
        }

        public ItemTypeConfigCreateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }
}