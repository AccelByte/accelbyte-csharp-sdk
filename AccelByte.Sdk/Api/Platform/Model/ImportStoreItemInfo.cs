// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ImportStoreItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ImportStoreItemInfoItemType? ItemType { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

    }

    public class ImportStoreItemInfoItemType : StringEnum<ImportStoreItemInfoItemType>
    {
        public static readonly ImportStoreItemInfoItemType APP
            = new ImportStoreItemInfoItemType("APP");

        public static readonly ImportStoreItemInfoItemType BUNDLE
            = new ImportStoreItemInfoItemType("BUNDLE");

        public static readonly ImportStoreItemInfoItemType CODE
            = new ImportStoreItemInfoItemType("CODE");

        public static readonly ImportStoreItemInfoItemType COINS
            = new ImportStoreItemInfoItemType("COINS");

        public static readonly ImportStoreItemInfoItemType EXTENSION
            = new ImportStoreItemInfoItemType("EXTENSION");

        public static readonly ImportStoreItemInfoItemType INGAMEITEM
            = new ImportStoreItemInfoItemType("INGAMEITEM");

        public static readonly ImportStoreItemInfoItemType MEDIA
            = new ImportStoreItemInfoItemType("MEDIA");

        public static readonly ImportStoreItemInfoItemType OPTIONBOX
            = new ImportStoreItemInfoItemType("OPTIONBOX");

        public static readonly ImportStoreItemInfoItemType SEASON
            = new ImportStoreItemInfoItemType("SEASON");

        public static readonly ImportStoreItemInfoItemType SUBSCRIPTION
            = new ImportStoreItemInfoItemType("SUBSCRIPTION");


        public static implicit operator ImportStoreItemInfoItemType(string value)
        {
            return NewValue(value);
        }

        public ImportStoreItemInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }
}