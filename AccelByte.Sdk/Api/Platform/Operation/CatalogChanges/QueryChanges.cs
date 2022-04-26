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
    /// queryChanges
    ///
    /// This API is used to query changes .
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    ///   *  Returns : the pagination of changes
    /// </summary>
    public class QueryChanges : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryChangesBuilder Builder = new QueryChangesBuilder();

        public class QueryChangesBuilder
            : OperationBuilder<QueryChangesBuilder>
        {
            
            
            public string? Action { get; set; }
            
            public string? ItemType { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? SortBy { get; set; }
            
            public string? Status { get; set; }
            
            public string? Type { get; set; }
            
            public string? UpdatedAtEnd { get; set; }
            
            public string? UpdatedAtStart { get; set; }
            
            internal QueryChangesBuilder() { }


            public QueryChangesBuilder SetAction(string _action)
            {
                Action = _action;
                return this;
            }

            public QueryChangesBuilder SetItemType(string _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public QueryChangesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryChangesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryChangesBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryChangesBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public QueryChangesBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public QueryChangesBuilder SetUpdatedAtEnd(string _updatedAtEnd)
            {
                UpdatedAtEnd = _updatedAtEnd;
                return this;
            }

            public QueryChangesBuilder SetUpdatedAtStart(string _updatedAtStart)
            {
                UpdatedAtStart = _updatedAtStart;
                return this;
            }





            public QueryChanges Build(
                string namespace_,
                string storeId
            )
            {
                QueryChanges op = new QueryChanges(this,
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryChanges(QueryChangesBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            if (builder.Action != null) QueryParams["action"] = builder.Action;
            if (builder.ItemType != null) QueryParams["itemType"] = builder.ItemType;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            if (builder.Type != null) QueryParams["type"] = builder.Type;
            if (builder.UpdatedAtEnd != null) QueryParams["updatedAtEnd"] = builder.UpdatedAtEnd;
            if (builder.UpdatedAtStart != null) QueryParams["updatedAtStart"] = builder.UpdatedAtStart;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryChanges(
            string namespace_,            
            string storeId,            
            string? action,            
            string? itemType,            
            int? limit,            
            int? offset,            
            string? sortBy,            
            string? status,            
            string? type,            
            string? updatedAtEnd,            
            string? updatedAtStart            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            if (action != null) QueryParams["action"] = action;
            if (itemType != null) QueryParams["itemType"] = itemType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (status != null) QueryParams["status"] = status;
            if (type != null) QueryParams["type"] = type;
            if (updatedAtEnd != null) QueryParams["updatedAtEnd"] = updatedAtEnd;
            if (updatedAtStart != null) QueryParams["updatedAtStart"] = updatedAtStart;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.CatalogChangePagingSlicedResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CatalogChangePagingSlicedResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CatalogChangePagingSlicedResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}