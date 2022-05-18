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

            public QueryChangesAction? Action { get; set; }

            public QueryChangesItemType? ItemType { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public QueryChangesStatus? Status { get; set; }

            public QueryChangesType? Type { get; set; }

            public string? UpdatedAtEnd { get; set; }

            public string? UpdatedAtStart { get; set; }





            internal QueryChangesBuilder() { }


            public QueryChangesBuilder SetAction(QueryChangesAction _action)
            {
                Action = _action;
                return this;
            }

            public QueryChangesBuilder SetItemType(QueryChangesItemType _itemType)
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

            public QueryChangesBuilder SetStatus(QueryChangesStatus _status)
            {
                Status = _status;
                return this;
            }

            public QueryChangesBuilder SetType(QueryChangesType _type)
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
            
            if (builder.Action is not null) QueryParams["action"] = builder.Action.Value;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.Type is not null) QueryParams["type"] = builder.Type.Value;
            if (builder.UpdatedAtEnd is not null) QueryParams["updatedAtEnd"] = builder.UpdatedAtEnd;
            if (builder.UpdatedAtStart is not null) QueryParams["updatedAtStart"] = builder.UpdatedAtStart;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryChanges(
            string namespace_,            
            string storeId,            
            QueryChangesAction? action,            
            QueryChangesItemType? itemType,            
            int? limit,            
            int? offset,            
            string? sortBy,            
            QueryChangesStatus? status,            
            QueryChangesType? type,            
            string? updatedAtEnd,            
            string? updatedAtStart            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            if (action is not null) QueryParams["action"] = action.Value;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status.Value;
            if (type is not null) QueryParams["type"] = type.Value;
            if (updatedAtEnd is not null) QueryParams["updatedAtEnd"] = updatedAtEnd;
            if (updatedAtStart is not null) QueryParams["updatedAtStart"] = updatedAtStart;
            

            
            
            

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

    public class QueryChangesAction : StringEnum<QueryChangesAction>
    {
        public static readonly QueryChangesAction Create
            = new QueryChangesAction("CREATE");

        public static readonly QueryChangesAction Delete
            = new QueryChangesAction("DELETE");

        public static readonly QueryChangesAction Update
            = new QueryChangesAction("UPDATE");


        public static implicit operator QueryChangesAction(string value)
        {
            return NewValue(value);
        }

        public QueryChangesAction(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryChangesItemType : StringEnum<QueryChangesItemType>
    {
        public static readonly QueryChangesItemType App
            = new QueryChangesItemType("APP");

        public static readonly QueryChangesItemType Bundle
            = new QueryChangesItemType("BUNDLE");

        public static readonly QueryChangesItemType Code
            = new QueryChangesItemType("CODE");

        public static readonly QueryChangesItemType Coins
            = new QueryChangesItemType("COINS");

        public static readonly QueryChangesItemType Ingameitem
            = new QueryChangesItemType("INGAMEITEM");

        public static readonly QueryChangesItemType Media
            = new QueryChangesItemType("MEDIA");

        public static readonly QueryChangesItemType Season
            = new QueryChangesItemType("SEASON");

        public static readonly QueryChangesItemType Subscription
            = new QueryChangesItemType("SUBSCRIPTION");


        public static implicit operator QueryChangesItemType(string value)
        {
            return NewValue(value);
        }

        public QueryChangesItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryChangesStatus : StringEnum<QueryChangesStatus>
    {
        public static readonly QueryChangesStatus Published
            = new QueryChangesStatus("PUBLISHED");

        public static readonly QueryChangesStatus Unpublished
            = new QueryChangesStatus("UNPUBLISHED");


        public static implicit operator QueryChangesStatus(string value)
        {
            return NewValue(value);
        }

        public QueryChangesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryChangesType : StringEnum<QueryChangesType>
    {
        public static readonly QueryChangesType Category
            = new QueryChangesType("CATEGORY");

        public static readonly QueryChangesType Item
            = new QueryChangesType("ITEM");

        public static readonly QueryChangesType Store
            = new QueryChangesType("STORE");


        public static implicit operator QueryChangesType(string value)
        {
            return NewValue(value);
        }

        public QueryChangesType(string enumValue)
            : base(enumValue)
        {

        }
    }

}