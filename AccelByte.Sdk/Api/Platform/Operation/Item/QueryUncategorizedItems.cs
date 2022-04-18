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
    /// queryUncategorizedItems
    ///
    /// This API is used to query uncategorized items within a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of uncategorized items
    /// </summary>
    public class QueryUncategorizedItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUncategorizedItemsBuilder Builder = new QueryUncategorizedItemsBuilder();

        public class QueryUncategorizedItemsBuilder
            : OperationBuilder<QueryUncategorizedItemsBuilder>
        {
            
            public bool? ActiveOnly { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? SortBy { get; set; }
            
            public string? StoreId { get; set; }
            
            internal QueryUncategorizedItemsBuilder() { }


            public QueryUncategorizedItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public QueryUncategorizedItems Build(
                string namespace_
            )
            {
                QueryUncategorizedItems op = new QueryUncategorizedItems(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryUncategorizedItems(QueryUncategorizedItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUncategorizedItems(
            string namespace_,            
            bool? activeOnly,            
            int? limit,            
            int? offset,            
            string? sortBy,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/uncategorized";

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