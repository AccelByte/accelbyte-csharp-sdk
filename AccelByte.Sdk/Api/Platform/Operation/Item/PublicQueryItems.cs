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
        public static PublicQueryItemsBuilder Builder = new PublicQueryItemsBuilder();

        public class PublicQueryItemsBuilder
            : OperationBuilder<PublicQueryItemsBuilder>
        {
            
            public string? AppType { get; set; }
            
            public string? BaseAppId { get; set; }
            
            public string? CategoryPath { get; set; }
            
            public string? Features { get; set; }
            
            public string? ItemType { get; set; }
            
            public string? Language { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Region { get; set; }
            
            public string? SortBy { get; set; }
            
            public string? StoreId { get; set; }
            
            public string? Tags { get; set; }
            
            internal PublicQueryItemsBuilder() { }


            public PublicQueryItemsBuilder SetAppType(string _appType)
            {
                AppType = _appType;
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

            public PublicQueryItemsBuilder SetItemType(string _itemType)
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

            public PublicQueryItemsBuilder SetSortBy(string _sortBy)
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

                return op;
            }
        }

        private PublicQueryItems(PublicQueryItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.AppType != null) QueryParams["appType"] = builder.AppType;
            if (builder.BaseAppId != null) QueryParams["baseAppId"] = builder.BaseAppId;
            if (builder.CategoryPath != null) QueryParams["categoryPath"] = builder.CategoryPath;
            if (builder.Features != null) QueryParams["features"] = builder.Features;
            if (builder.ItemType != null) QueryParams["itemType"] = builder.ItemType;
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            

            
            
            

        }
        #endregion

        public PublicQueryItems(
            string namespace_,            
            string? appType,            
            string? baseAppId,            
            string? categoryPath,            
            string? features,            
            string? itemType,            
            string? language,            
            int? limit,            
            int? offset,            
            string? region,            
            string? sortBy,            
            string? storeId,            
            string? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appType != null) QueryParams["appType"] = appType;
            if (baseAppId != null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath != null) QueryParams["categoryPath"] = categoryPath;
            if (features != null) QueryParams["features"] = features;
            if (itemType != null) QueryParams["itemType"] = itemType;
            if (language != null) QueryParams["language"] = language;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (tags != null) QueryParams["tags"] = tags;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}