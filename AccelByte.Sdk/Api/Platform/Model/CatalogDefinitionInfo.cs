// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CatalogDefinitionInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("field")]
        public string? Field { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CatalogDefinitionInfoItemType? ItemType { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("required")]
        public bool? Required { get; set; }

    }



    public class CatalogDefinitionInfoItemType : StringEnum<CatalogDefinitionInfoItemType>
    {
        public static readonly CatalogDefinitionInfoItemType APP
            = new CatalogDefinitionInfoItemType("APP");

        public static readonly CatalogDefinitionInfoItemType BUNDLE
            = new CatalogDefinitionInfoItemType("BUNDLE");

        public static readonly CatalogDefinitionInfoItemType CODE
            = new CatalogDefinitionInfoItemType("CODE");

        public static readonly CatalogDefinitionInfoItemType COINS
            = new CatalogDefinitionInfoItemType("COINS");

        public static readonly CatalogDefinitionInfoItemType EXTENSION
            = new CatalogDefinitionInfoItemType("EXTENSION");

        public static readonly CatalogDefinitionInfoItemType INGAMEITEM
            = new CatalogDefinitionInfoItemType("INGAMEITEM");

        public static readonly CatalogDefinitionInfoItemType LOOTBOX
            = new CatalogDefinitionInfoItemType("LOOTBOX");

        public static readonly CatalogDefinitionInfoItemType MEDIA
            = new CatalogDefinitionInfoItemType("MEDIA");

        public static readonly CatalogDefinitionInfoItemType OPTIONBOX
            = new CatalogDefinitionInfoItemType("OPTIONBOX");

        public static readonly CatalogDefinitionInfoItemType SEASON
            = new CatalogDefinitionInfoItemType("SEASON");

        public static readonly CatalogDefinitionInfoItemType SUBSCRIPTION
            = new CatalogDefinitionInfoItemType("SUBSCRIPTION");


        public static implicit operator CatalogDefinitionInfoItemType(string value)
        {
            return NewValue(value);
        }

        public CatalogDefinitionInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }
}