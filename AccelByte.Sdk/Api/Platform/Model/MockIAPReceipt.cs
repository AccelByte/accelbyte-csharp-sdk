// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class MockIAPReceipt : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemIdentityType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public MockIAPReceiptItemIdentityType? ItemIdentityType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public MockIAPReceiptType? Type { get; set; }

    }



    public class MockIAPReceiptItemIdentityType : StringEnum<MockIAPReceiptItemIdentityType>
    {
        public static readonly MockIAPReceiptItemIdentityType ITEMID
            = new MockIAPReceiptItemIdentityType("ITEM_ID");

        public static readonly MockIAPReceiptItemIdentityType ITEMSKU
            = new MockIAPReceiptItemIdentityType("ITEM_SKU");


        public static implicit operator MockIAPReceiptItemIdentityType(string value)
        {
            return NewValue(value);
        }

        public MockIAPReceiptItemIdentityType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class MockIAPReceiptType : StringEnum<MockIAPReceiptType>
    {
        public static readonly MockIAPReceiptType APPLE
            = new MockIAPReceiptType("APPLE");

        public static readonly MockIAPReceiptType EPICGAMES
            = new MockIAPReceiptType("EPICGAMES");

        public static readonly MockIAPReceiptType GOOGLE
            = new MockIAPReceiptType("GOOGLE");

        public static readonly MockIAPReceiptType PLAYSTATION
            = new MockIAPReceiptType("PLAYSTATION");

        public static readonly MockIAPReceiptType STADIA
            = new MockIAPReceiptType("STADIA");

        public static readonly MockIAPReceiptType STEAM
            = new MockIAPReceiptType("STEAM");

        public static readonly MockIAPReceiptType TWITCH
            = new MockIAPReceiptType("TWITCH");

        public static readonly MockIAPReceiptType XBOX
            = new MockIAPReceiptType("XBOX");


        public static implicit operator MockIAPReceiptType(string value)
        {
            return NewValue(value);
        }

        public MockIAPReceiptType(string enumValue)
            : base(enumValue)
        {

        }
    }
}