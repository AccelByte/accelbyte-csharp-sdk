// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CatalogChangeInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonStringEnum]
        public CatalogChangeInfoAction? Action { get; set; }

        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("changeId")]
        public string? ChangeId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public CatalogChangeInfoItemType? ItemType { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public CatalogChangeInfoStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public CatalogChangeInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class CatalogChangeInfoAction : StringEnum<CatalogChangeInfoAction>
    {
        public static readonly CatalogChangeInfoAction CREATE
            = new CatalogChangeInfoAction("CREATE");

        public static readonly CatalogChangeInfoAction UPDATE
            = new CatalogChangeInfoAction("UPDATE");

        public static readonly CatalogChangeInfoAction DELETE
            = new CatalogChangeInfoAction("DELETE");


        public static implicit operator CatalogChangeInfoAction(string value)
        {
            return Create(value);
        }

        public CatalogChangeInfoAction(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CatalogChangeInfoItemType : StringEnum<CatalogChangeInfoItemType>
    {
        public static readonly CatalogChangeInfoItemType APP
            = new CatalogChangeInfoItemType("APP");

        public static readonly CatalogChangeInfoItemType COINS
            = new CatalogChangeInfoItemType("COINS");

        public static readonly CatalogChangeInfoItemType INGAMEITEM
            = new CatalogChangeInfoItemType("INGAMEITEM");

        public static readonly CatalogChangeInfoItemType BUNDLE
            = new CatalogChangeInfoItemType("BUNDLE");

        public static readonly CatalogChangeInfoItemType CODE
            = new CatalogChangeInfoItemType("CODE");

        public static readonly CatalogChangeInfoItemType SUBSCRIPTION
            = new CatalogChangeInfoItemType("SUBSCRIPTION");

        public static readonly CatalogChangeInfoItemType SEASON
            = new CatalogChangeInfoItemType("SEASON");

        public static readonly CatalogChangeInfoItemType MEDIA
            = new CatalogChangeInfoItemType("MEDIA");


        public static implicit operator CatalogChangeInfoItemType(string value)
        {
            return Create(value);
        }

        public CatalogChangeInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CatalogChangeInfoStatus : StringEnum<CatalogChangeInfoStatus>
    {
        public static readonly CatalogChangeInfoStatus UNPUBLISHED
            = new CatalogChangeInfoStatus("UNPUBLISHED");

        public static readonly CatalogChangeInfoStatus PUBLISHED
            = new CatalogChangeInfoStatus("PUBLISHED");


        public static implicit operator CatalogChangeInfoStatus(string value)
        {
            return Create(value);
        }

        public CatalogChangeInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CatalogChangeInfoType : StringEnum<CatalogChangeInfoType>
    {
        public static readonly CatalogChangeInfoType STORE
            = new CatalogChangeInfoType("STORE");

        public static readonly CatalogChangeInfoType CATEGORY
            = new CatalogChangeInfoType("CATEGORY");

        public static readonly CatalogChangeInfoType ITEM
            = new CatalogChangeInfoType("ITEM");


        public static implicit operator CatalogChangeInfoType(string value)
        {
            return Create(value);
        }

        public CatalogChangeInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}