// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicQueryItems
    ///
    /// This API is used to query items by criteria within a store. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the list of items
    /// </summary>
    public class PublicQueryItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryItemsBuilder Builder { get => new PublicQueryItemsBuilder(); }

        public class PublicQueryItemsBuilder
            : OperationBuilder<PublicQueryItemsBuilder>
        {

            public PublicQueryItemsAppType? AppType { get; set; }

            public bool? AutoCalcEstimatedPrice { get; set; }

            public string? BaseAppId { get; set; }

            public string? CategoryPath { get; set; }

            public string? Features { get; set; }

            public bool? IncludeSubCategoryItem { get; set; }

            public PublicQueryItemsItemType? ItemType { get; set; }

            public string? Language { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Region { get; set; }

            public List<PublicQueryItemsSortBy>? SortBy { get; set; }

            public string? StoreId { get; set; }

            public string? Tags { get; set; }





            internal PublicQueryItemsBuilder() { }


            public PublicQueryItemsBuilder SetAppType(PublicQueryItemsAppType _appType)
            {
                AppType = _appType;
                return this;
            }

            public PublicQueryItemsBuilder SetAutoCalcEstimatedPrice(bool _autoCalcEstimatedPrice)
            {
                AutoCalcEstimatedPrice = _autoCalcEstimatedPrice;
                return this;
            }

            public PublicQueryItemsBuilder SetBaseAppId(string _baseAppId)
            {
                BaseAppId = _baseAppId;
                return this;
            }

            public PublicQueryItemsBuilder SetCategoryPath(string _categoryPath)
            {
                CategoryPath = _categoryPath;
                return this;
            }

            public PublicQueryItemsBuilder SetFeatures(string _features)
            {
                Features = _features;
                return this;
            }

            public PublicQueryItemsBuilder SetIncludeSubCategoryItem(bool _includeSubCategoryItem)
            {
                IncludeSubCategoryItem = _includeSubCategoryItem;
                return this;
            }

            public PublicQueryItemsBuilder SetItemType(PublicQueryItemsItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public PublicQueryItemsBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicQueryItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicQueryItemsBuilder SetSortBy(List<PublicQueryItemsSortBy> _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicQueryItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public PublicQueryItemsBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicQueryItems Build(
                string namespace_
            )
            {
                PublicQueryItems op = new PublicQueryItems(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicQueryItems(PublicQueryItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.AppType is not null) QueryParams["appType"] = builder.AppType.Value;
            if (builder.AutoCalcEstimatedPrice != null) QueryParams["autoCalcEstimatedPrice"] = Convert.ToString(builder.AutoCalcEstimatedPrice)!;
            if (builder.BaseAppId is not null) QueryParams["baseAppId"] = builder.BaseAppId;
            if (builder.CategoryPath is not null) QueryParams["categoryPath"] = builder.CategoryPath;
            if (builder.Features is not null) QueryParams["features"] = builder.Features;
            if (builder.IncludeSubCategoryItem != null) QueryParams["includeSubCategoryItem"] = Convert.ToString(builder.IncludeSubCategoryItem)!;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryItems(
            string namespace_,
            PublicQueryItemsAppType? appType,
            bool? autoCalcEstimatedPrice,
            string? baseAppId,
            string? categoryPath,
            string? features,
            bool? includeSubCategoryItem,
            PublicQueryItemsItemType? itemType,
            string? language,
            int? limit,
            int? offset,
            string? region,
            List<PublicQueryItemsSortBy>? sortBy,
            string? storeId,
            string? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (appType is not null) QueryParams["appType"] = appType.Value;
            if (autoCalcEstimatedPrice != null) QueryParams["autoCalcEstimatedPrice"] = Convert.ToString(autoCalcEstimatedPrice)!;
            if (baseAppId is not null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath is not null) QueryParams["categoryPath"] = categoryPath;
            if (features is not null) QueryParams["features"] = features;
            if (includeSubCategoryItem != null) QueryParams["includeSubCategoryItem"] = Convert.ToString(includeSubCategoryItem)!;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (language is not null) QueryParams["language"] = language;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region is not null) QueryParams["region"] = region;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicQueryItemsAppType : StringEnum<PublicQueryItemsAppType>
    {
        public static readonly PublicQueryItemsAppType DEMO
            = new PublicQueryItemsAppType("DEMO");

        public static readonly PublicQueryItemsAppType DLC
            = new PublicQueryItemsAppType("DLC");

        public static readonly PublicQueryItemsAppType GAME
            = new PublicQueryItemsAppType("GAME");

        public static readonly PublicQueryItemsAppType SOFTWARE
            = new PublicQueryItemsAppType("SOFTWARE");


        public static implicit operator PublicQueryItemsAppType(string value)
        {
            return NewValue(value);
        }

        public PublicQueryItemsAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PublicQueryItemsItemType : StringEnum<PublicQueryItemsItemType>
    {
        public static readonly PublicQueryItemsItemType APP
            = new PublicQueryItemsItemType("APP");

        public static readonly PublicQueryItemsItemType BUNDLE
            = new PublicQueryItemsItemType("BUNDLE");

        public static readonly PublicQueryItemsItemType CODE
            = new PublicQueryItemsItemType("CODE");

        public static readonly PublicQueryItemsItemType COINS
            = new PublicQueryItemsItemType("COINS");

        public static readonly PublicQueryItemsItemType EXTENSION
            = new PublicQueryItemsItemType("EXTENSION");

        public static readonly PublicQueryItemsItemType INGAMEITEM
            = new PublicQueryItemsItemType("INGAMEITEM");

        public static readonly PublicQueryItemsItemType LOOTBOX
            = new PublicQueryItemsItemType("LOOTBOX");

        public static readonly PublicQueryItemsItemType MEDIA
            = new PublicQueryItemsItemType("MEDIA");

        public static readonly PublicQueryItemsItemType OPTIONBOX
            = new PublicQueryItemsItemType("OPTIONBOX");

        public static readonly PublicQueryItemsItemType SEASON
            = new PublicQueryItemsItemType("SEASON");

        public static readonly PublicQueryItemsItemType SUBSCRIPTION
            = new PublicQueryItemsItemType("SUBSCRIPTION");


        public static implicit operator PublicQueryItemsItemType(string value)
        {
            return NewValue(value);
        }

        public PublicQueryItemsItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PublicQueryItemsSortBy : StringEnum<PublicQueryItemsSortBy>
    {
        public static readonly PublicQueryItemsSortBy Name
            = new PublicQueryItemsSortBy("name");

        public static readonly PublicQueryItemsSortBy Nameasc
            = new PublicQueryItemsSortBy("name:asc");

        public static readonly PublicQueryItemsSortBy Namedesc
            = new PublicQueryItemsSortBy("name:desc");

        public static readonly PublicQueryItemsSortBy CreatedAt
            = new PublicQueryItemsSortBy("createdAt");

        public static readonly PublicQueryItemsSortBy CreatedAtasc
            = new PublicQueryItemsSortBy("createdAt:asc");

        public static readonly PublicQueryItemsSortBy CreatedAtdesc
            = new PublicQueryItemsSortBy("createdAt:desc");

        public static readonly PublicQueryItemsSortBy UpdatedAt
            = new PublicQueryItemsSortBy("updatedAt");

        public static readonly PublicQueryItemsSortBy UpdatedAtasc
            = new PublicQueryItemsSortBy("updatedAt:asc");

        public static readonly PublicQueryItemsSortBy UpdatedAtdesc
            = new PublicQueryItemsSortBy("updatedAt:desc");

        public static readonly PublicQueryItemsSortBy DisplayOrder
            = new PublicQueryItemsSortBy("displayOrder");

        public static readonly PublicQueryItemsSortBy DisplayOrderasc
            = new PublicQueryItemsSortBy("displayOrder:asc");

        public static readonly PublicQueryItemsSortBy DisplayOrderdesc
            = new PublicQueryItemsSortBy("displayOrder:desc");


        public static implicit operator PublicQueryItemsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicQueryItemsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}