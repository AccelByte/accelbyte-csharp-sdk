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
    /// searchItems
    ///
    /// This API is used to search items by keyword in title, description and long description within a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of items
    /// </summary>
    public class SearchItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchItemsBuilder Builder = new SearchItemsBuilder();

        public class SearchItemsBuilder
        {
            
            public bool? ActiveOnly { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? StoreId { get; set; }
            
            
            
            internal SearchItemsBuilder() { }


            public SearchItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public SearchItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public SearchItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public SearchItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public SearchItems Build(
                string namespace_,
                string keyword,
                string language
            )
            {
                return new SearchItems(this,
                    namespace_,                    
                    keyword,                    
                    language                    
                );
            }
        }

        private SearchItems(SearchItemsBuilder builder,
            string namespace_,
            string keyword,
            string language
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (keyword != null) QueryParams["keyword"] = keyword;
            if (language != null) QueryParams["language"] = language;
            
            
            
            
        }
        #endregion

        public SearchItems(
            string namespace_,            
            bool? activeOnly,            
            int? limit,            
            int? offset,            
            string? storeId,            
            string keyword,            
            string language            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (keyword != null) QueryParams["keyword"] = keyword;
            if (language != null) QueryParams["language"] = language;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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