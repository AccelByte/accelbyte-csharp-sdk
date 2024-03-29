// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemTypeConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("dryRun")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DryRun { get; set; }

        [JsonPropertyName("fulfillmentUrl")]
        public string? FulfillmentUrl { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemTypeConfigInfoItemType? ItemType { get; set; }

        [JsonPropertyName("purchaseConditionUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PurchaseConditionUrl { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }



    public class ItemTypeConfigInfoItemType : StringEnum<ItemTypeConfigInfoItemType>
    {
        public static readonly ItemTypeConfigInfoItemType APP
            = new ItemTypeConfigInfoItemType("APP");

        public static readonly ItemTypeConfigInfoItemType BUNDLE
            = new ItemTypeConfigInfoItemType("BUNDLE");

        public static readonly ItemTypeConfigInfoItemType CODE
            = new ItemTypeConfigInfoItemType("CODE");

        public static readonly ItemTypeConfigInfoItemType COINS
            = new ItemTypeConfigInfoItemType("COINS");

        public static readonly ItemTypeConfigInfoItemType EXTENSION
            = new ItemTypeConfigInfoItemType("EXTENSION");

        public static readonly ItemTypeConfigInfoItemType INGAMEITEM
            = new ItemTypeConfigInfoItemType("INGAMEITEM");

        public static readonly ItemTypeConfigInfoItemType LOOTBOX
            = new ItemTypeConfigInfoItemType("LOOTBOX");

        public static readonly ItemTypeConfigInfoItemType MEDIA
            = new ItemTypeConfigInfoItemType("MEDIA");

        public static readonly ItemTypeConfigInfoItemType OPTIONBOX
            = new ItemTypeConfigInfoItemType("OPTIONBOX");

        public static readonly ItemTypeConfigInfoItemType SEASON
            = new ItemTypeConfigInfoItemType("SEASON");

        public static readonly ItemTypeConfigInfoItemType SUBSCRIPTION
            = new ItemTypeConfigInfoItemType("SUBSCRIPTION");


        public static implicit operator ItemTypeConfigInfoItemType(string value)
        {
            return NewValue(value);
        }

        public ItemTypeConfigInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }
}