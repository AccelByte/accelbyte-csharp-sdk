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
    /// queryItems_1
    ///
    /// This API is used to query items by criteria within a store.
    /// 
    /// The behaviour for itemStatus query parameter:
    /// * TRUE: Show only ACTIVE items
    /// * FALSE: Show only INACTIVE items
    /// * Not provided: show both ACTIVE and INACTIVE items
    /// Other detail info:
    /// 
    ///   * Returns : the list of items
    /// </summary>
    public class QueryItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryItems1Builder Builder { get => new QueryItems1Builder(); }

        public class QueryItems1Builder
            : OperationBuilder<QueryItems1Builder>
        {

            public QueryItems1AppType? AppType { get; set; }

            public string? AvailableDate { get; set; }

            public string? BaseAppId { get; set; }

            public string? CategoryPath { get; set; }

            public string? Features { get; set; }

            public bool? IncludeSubCategoryItem { get; set; }

            public string? ItemName { get; set; }

            public QueryItems1ItemStatus? ItemStatus { get; set; }

            public QueryItems1ItemType? ItemType { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Region { get; set; }

            public bool? SectionExclusive { get; set; }

            public List<QueryItems1SortBy>? SortBy { get; set; }

            public string? StoreId { get; set; }

            public string? Tags { get; set; }

            public string? TargetNamespace { get; set; }

            public bool? WithTotal { get; set; }





            internal QueryItems1Builder() { }


            public QueryItems1Builder SetAppType(QueryItems1AppType _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryItems1Builder SetAvailableDate(string _availableDate)
            {
                AvailableDate = _availableDate;
                return this;
            }

            public QueryItems1Builder SetBaseAppId(string _baseAppId)
            {
                BaseAppId = _baseAppId;
                return this;
            }

            public QueryItems1Builder SetCategoryPath(string _categoryPath)
            {
                CategoryPath = _categoryPath;
                return this;
            }

            public QueryItems1Builder SetFeatures(string _features)
            {
                Features = _features;
                return this;
            }

            public QueryItems1Builder SetIncludeSubCategoryItem(bool _includeSubCategoryItem)
            {
                IncludeSubCategoryItem = _includeSubCategoryItem;
                return this;
            }

            public QueryItems1Builder SetItemName(string _itemName)
            {
                ItemName = _itemName;
                return this;
            }

            public QueryItems1Builder SetItemStatus(QueryItems1ItemStatus _itemStatus)
            {
                ItemStatus = _itemStatus;
                return this;
            }

            public QueryItems1Builder SetItemType(QueryItems1ItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public QueryItems1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryItems1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryItems1Builder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public QueryItems1Builder SetSectionExclusive(bool _sectionExclusive)
            {
                SectionExclusive = _sectionExclusive;
                return this;
            }

            public QueryItems1Builder SetSortBy(List<QueryItems1SortBy> _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryItems1Builder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public QueryItems1Builder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public QueryItems1Builder SetTargetNamespace(string _targetNamespace)
            {
                TargetNamespace = _targetNamespace;
                return this;
            }

            public QueryItems1Builder SetWithTotal(bool _withTotal)
            {
                WithTotal = _withTotal;
                return this;
            }





            public QueryItems1 Build(
                string namespace_
            )
            {
                QueryItems1 op = new QueryItems1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryItems1(QueryItems1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.AppType is not null) QueryParams["appType"] = builder.AppType.Value;
            if (builder.AvailableDate is not null) QueryParams["availableDate"] = builder.AvailableDate;
            if (builder.BaseAppId is not null) QueryParams["baseAppId"] = builder.BaseAppId;
            if (builder.CategoryPath is not null) QueryParams["categoryPath"] = builder.CategoryPath;
            if (builder.Features is not null) QueryParams["features"] = builder.Features;
            if (builder.IncludeSubCategoryItem != null) QueryParams["includeSubCategoryItem"] = Convert.ToString(builder.IncludeSubCategoryItem)!;
            if (builder.ItemName is not null) QueryParams["itemName"] = builder.ItemName;
            if (builder.ItemStatus is not null) QueryParams["itemStatus"] = builder.ItemStatus.Value;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.SectionExclusive != null) QueryParams["sectionExclusive"] = Convert.ToString(builder.SectionExclusive)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.TargetNamespace is not null) QueryParams["targetNamespace"] = builder.TargetNamespace;
            if (builder.WithTotal != null) QueryParams["withTotal"] = Convert.ToString(builder.WithTotal)!;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryItems1(
            string namespace_,
            QueryItems1AppType? appType,
            string? availableDate,
            string? baseAppId,
            string? categoryPath,
            string? features,
            bool? includeSubCategoryItem,
            string? itemName,
            QueryItems1ItemStatus? itemStatus,
            QueryItems1ItemType? itemType,
            int? limit,
            int? offset,
            string? region,
            bool? sectionExclusive,
            List<QueryItems1SortBy>? sortBy,
            string? storeId,
            string? tags,
            string? targetNamespace,
            bool? withTotal
        )
        {
            PathParams["namespace"] = namespace_;

            if (appType is not null) QueryParams["appType"] = appType.Value;
            if (availableDate is not null) QueryParams["availableDate"] = availableDate;
            if (baseAppId is not null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath is not null) QueryParams["categoryPath"] = categoryPath;
            if (features is not null) QueryParams["features"] = features;
            if (includeSubCategoryItem != null) QueryParams["includeSubCategoryItem"] = Convert.ToString(includeSubCategoryItem)!;
            if (itemName is not null) QueryParams["itemName"] = itemName;
            if (itemStatus is not null) QueryParams["itemStatus"] = itemStatus.Value;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region is not null) QueryParams["region"] = region;
            if (sectionExclusive != null) QueryParams["sectionExclusive"] = Convert.ToString(sectionExclusive)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (tags is not null) QueryParams["tags"] = tags;
            if (targetNamespace is not null) QueryParams["targetNamespace"] = targetNamespace;
            if (withTotal != null) QueryParams["withTotal"] = Convert.ToString(withTotal)!;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FullItemPagingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.FullItemPagingResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.FullItemPagingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryItems1AppType : StringEnum<QueryItems1AppType>
    {
        public static readonly QueryItems1AppType DEMO
            = new QueryItems1AppType("DEMO");

        public static readonly QueryItems1AppType DLC
            = new QueryItems1AppType("DLC");

        public static readonly QueryItems1AppType GAME
            = new QueryItems1AppType("GAME");

        public static readonly QueryItems1AppType SOFTWARE
            = new QueryItems1AppType("SOFTWARE");


        public static implicit operator QueryItems1AppType(string value)
        {
            return NewValue(value);
        }

        public QueryItems1AppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryItems1ItemStatus : StringEnum<QueryItems1ItemStatus>
    {
        public static readonly QueryItems1ItemStatus ACTIVE
            = new QueryItems1ItemStatus("ACTIVE");

        public static readonly QueryItems1ItemStatus INACTIVE
            = new QueryItems1ItemStatus("INACTIVE");


        public static implicit operator QueryItems1ItemStatus(string value)
        {
            return NewValue(value);
        }

        public QueryItems1ItemStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryItems1ItemType : StringEnum<QueryItems1ItemType>
    {
        public static readonly QueryItems1ItemType APP
            = new QueryItems1ItemType("APP");

        public static readonly QueryItems1ItemType BUNDLE
            = new QueryItems1ItemType("BUNDLE");

        public static readonly QueryItems1ItemType CODE
            = new QueryItems1ItemType("CODE");

        public static readonly QueryItems1ItemType COINS
            = new QueryItems1ItemType("COINS");

        public static readonly QueryItems1ItemType EXTENSION
            = new QueryItems1ItemType("EXTENSION");

        public static readonly QueryItems1ItemType INGAMEITEM
            = new QueryItems1ItemType("INGAMEITEM");

        public static readonly QueryItems1ItemType LOOTBOX
            = new QueryItems1ItemType("LOOTBOX");

        public static readonly QueryItems1ItemType MEDIA
            = new QueryItems1ItemType("MEDIA");

        public static readonly QueryItems1ItemType OPTIONBOX
            = new QueryItems1ItemType("OPTIONBOX");

        public static readonly QueryItems1ItemType SEASON
            = new QueryItems1ItemType("SEASON");

        public static readonly QueryItems1ItemType SUBSCRIPTION
            = new QueryItems1ItemType("SUBSCRIPTION");


        public static implicit operator QueryItems1ItemType(string value)
        {
            return NewValue(value);
        }

        public QueryItems1ItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryItems1SortBy : StringEnum<QueryItems1SortBy>
    {
        public static readonly QueryItems1SortBy Name
            = new QueryItems1SortBy("name");

        public static readonly QueryItems1SortBy Nameasc
            = new QueryItems1SortBy("name:asc");

        public static readonly QueryItems1SortBy Namedesc
            = new QueryItems1SortBy("name:desc");

        public static readonly QueryItems1SortBy CreatedAt
            = new QueryItems1SortBy("createdAt");

        public static readonly QueryItems1SortBy CreatedAtasc
            = new QueryItems1SortBy("createdAt:asc");

        public static readonly QueryItems1SortBy CreatedAtdesc
            = new QueryItems1SortBy("createdAt:desc");

        public static readonly QueryItems1SortBy UpdatedAt
            = new QueryItems1SortBy("updatedAt");

        public static readonly QueryItems1SortBy UpdatedAtasc
            = new QueryItems1SortBy("updatedAt:asc");

        public static readonly QueryItems1SortBy UpdatedAtdesc
            = new QueryItems1SortBy("updatedAt:desc");

        public static readonly QueryItems1SortBy DisplayOrder
            = new QueryItems1SortBy("displayOrder");

        public static readonly QueryItems1SortBy DisplayOrderasc
            = new QueryItems1SortBy("displayOrder:asc");

        public static readonly QueryItems1SortBy DisplayOrderdesc
            = new QueryItems1SortBy("displayOrder:desc");


        public static implicit operator QueryItems1SortBy(string value)
        {
            return NewValue(value);
        }

        public QueryItems1SortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}