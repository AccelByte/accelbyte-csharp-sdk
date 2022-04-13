// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extraSubscriptionDays")]
        public int? ExtraSubscriptionDays { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemName")]
        public string? ItemName { get; set; }

        [JsonPropertyName("itemSku")]
        public string? ItemSku { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public FulfillmentItemItemType? ItemType { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

    }

    public class FulfillmentItemItemType : StringEnum<FulfillmentItemItemType>
    {
        public static readonly FulfillmentItemItemType APP
            = new FulfillmentItemItemType("APP");

        public static readonly FulfillmentItemItemType COINS
            = new FulfillmentItemItemType("COINS");

        public static readonly FulfillmentItemItemType INGAMEITEM
            = new FulfillmentItemItemType("INGAMEITEM");

        public static readonly FulfillmentItemItemType BUNDLE
            = new FulfillmentItemItemType("BUNDLE");

        public static readonly FulfillmentItemItemType CODE
            = new FulfillmentItemItemType("CODE");

        public static readonly FulfillmentItemItemType SUBSCRIPTION
            = new FulfillmentItemItemType("SUBSCRIPTION");

        public static readonly FulfillmentItemItemType SEASON
            = new FulfillmentItemItemType("SEASON");

        public static readonly FulfillmentItemItemType MEDIA
            = new FulfillmentItemItemType("MEDIA");


        public static implicit operator FulfillmentItemItemType(string value)
        {
            return Create(value);
        }

        public FulfillmentItemItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}