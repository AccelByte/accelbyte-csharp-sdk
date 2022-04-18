// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryItems
    ///
    /// This API is used to query items by criteria within a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of items
    /// </summary>
    public class QueryItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryItemsBuilder Builder = new QueryItemsBuilder();

        public class QueryItemsBuilder
            : OperationBuilder<QueryItemsBuilder>
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? AppType { get; set; }
            
            public string? AvailableDate { get; set; }
            
            public string? BaseAppId { get; set; }
            
            public string? CategoryPath { get; set; }
            
            public string? Features { get; set; }
            
            public string? ItemType { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Region { get; set; }
            
            public string? SortBy { get; set; }
            
            public string? StoreId { get; set; }
            
            public string? Tags { get; set; }
            
            public string? TargetNamespace { get; set; }
            
            internal QueryItemsBuilder() { }


            public QueryItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryItemsBuilder SetAppType(string _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryItemsBuilder SetAvailableDate(string _availableDate)
            {
                AvailableDate = _availableDate;
                return this;
            }

            public QueryItemsBuilder SetBaseAppId(string _baseAppId)
            {
                BaseAppId = _baseAppId;
                return this;
            }

            public QueryItemsBuilder SetCategoryPath(string _categoryPath)
            {
                CategoryPath = _categoryPath;
                return this;
            }

            public QueryItemsBuilder SetFeatures(string _features)
            {
                Features = _features;
                return this;
            }

            public QueryItemsBuilder SetItemType(string _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public QueryItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public QueryItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public QueryItemsBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public QueryItemsBuilder SetTargetNamespace(string _targetNamespace)
            {
                TargetNamespace = _targetNamespace;
                return this;
            }




            public QueryItems Build(
                string namespace_
            )
            {
                QueryItems op = new QueryItems(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryItems(QueryItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.AppType != null) QueryParams["appType"] = builder.AppType;
            if (builder.AvailableDate != null) QueryParams["availableDate"] = builder.AvailableDate;
            if (builder.BaseAppId != null) QueryParams["baseAppId"] = builder.BaseAppId;
            if (builder.CategoryPath != null) QueryParams["categoryPath"] = builder.CategoryPath;
            if (builder.Features != null) QueryParams["features"] = builder.Features;
            if (builder.ItemType != null) QueryParams["itemType"] = builder.ItemType;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            if (builder.TargetNamespace != null) QueryParams["targetNamespace"] = builder.TargetNamespace;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryItems(
            string namespace_,            
            bool? activeOnly,            
            string? appType,            
            string? availableDate,            
            string? baseAppId,            
            string? categoryPath,            
            string? features,            
            string? itemType,            
            int? limit,            
            int? offset,            
            string? region,            
            string? sortBy,            
            string? storeId,            
            string? tags,            
            string? targetNamespace            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appType != null) QueryParams["appType"] = appType;
            if (availableDate != null) QueryParams["availableDate"] = availableDate;
            if (baseAppId != null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath != null) QueryParams["categoryPath"] = categoryPath;
            if (features != null) QueryParams["features"] = features;
            if (itemType != null) QueryParams["itemType"] = itemType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (tags != null) QueryParams["tags"] = tags;
            if (targetNamespace != null) QueryParams["targetNamespace"] = targetNamespace;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.FullItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}