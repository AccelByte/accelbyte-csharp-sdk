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
    ///   * Returns : the pagination of changes
    /// </summary>
    public class QueryChanges : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryChangesBuilder Builder { get => new QueryChangesBuilder(); }

        public class QueryChangesBuilder
            : OperationBuilder<QueryChangesBuilder>
        {

            public QueryChangesAction? Action { get; set; }

            public string? ItemSku { get; set; }

            public QueryChangesItemType? ItemType { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public bool? Selected { get; set; }

            public List<QueryChangesSortBy>? SortBy { get; set; }

            public QueryChangesStatus? Status { get; set; }

            public QueryChangesType? Type { get; set; }

            public string? UpdatedAtEnd { get; set; }

            public string? UpdatedAtStart { get; set; }

            public bool? WithTotal { get; set; }





            internal QueryChangesBuilder() { }


            public QueryChangesBuilder SetAction(QueryChangesAction _action)
            {
                Action = _action;
                return this;
            }

            public QueryChangesBuilder SetItemSku(string _itemSku)
            {
                ItemSku = _itemSku;
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

            public QueryChangesBuilder SetSelected(bool _selected)
            {
                Selected = _selected;
                return this;
            }

            public QueryChangesBuilder SetSortBy(List<QueryChangesSortBy> _sortBy)
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

            public QueryChangesBuilder SetWithTotal(bool _withTotal)
            {
                WithTotal = _withTotal;
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
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

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
            if (builder.ItemSku is not null) QueryParams["itemSku"] = builder.ItemSku;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Selected != null) QueryParams["selected"] = Convert.ToString(builder.Selected)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.Type is not null) QueryParams["type"] = builder.Type.Value;
            if (builder.UpdatedAtEnd is not null) QueryParams["updatedAtEnd"] = builder.UpdatedAtEnd;
            if (builder.UpdatedAtStart is not null) QueryParams["updatedAtStart"] = builder.UpdatedAtStart;
            if (builder.WithTotal != null) QueryParams["withTotal"] = Convert.ToString(builder.WithTotal)!;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryChanges(
            string namespace_,
            string storeId,
            QueryChangesAction? action,
            string? itemSku,
            QueryChangesItemType? itemType,
            int? limit,
            int? offset,
            bool? selected,
            List<QueryChangesSortBy>? sortBy,
            QueryChangesStatus? status,
            QueryChangesType? type,
            string? updatedAtEnd,
            string? updatedAtStart,
            bool? withTotal
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (action is not null) QueryParams["action"] = action.Value;
            if (itemSku is not null) QueryParams["itemSku"] = itemSku;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (selected != null) QueryParams["selected"] = Convert.ToString(selected)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status.Value;
            if (type is not null) QueryParams["type"] = type.Value;
            if (updatedAtEnd is not null) QueryParams["updatedAtEnd"] = updatedAtEnd;
            if (updatedAtStart is not null) QueryParams["updatedAtStart"] = updatedAtStart;
            if (withTotal != null) QueryParams["withTotal"] = Convert.ToString(withTotal)!;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.CatalogChangePagingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.CatalogChangePagingResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.CatalogChangePagingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CatalogChangePagingResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryChangesAction : StringEnum<QueryChangesAction>
    {
        public static readonly QueryChangesAction CREATE
            = new QueryChangesAction("CREATE");

        public static readonly QueryChangesAction DELETE
            = new QueryChangesAction("DELETE");

        public static readonly QueryChangesAction UPDATE
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
        public static readonly QueryChangesItemType APP
            = new QueryChangesItemType("APP");

        public static readonly QueryChangesItemType BUNDLE
            = new QueryChangesItemType("BUNDLE");

        public static readonly QueryChangesItemType CODE
            = new QueryChangesItemType("CODE");

        public static readonly QueryChangesItemType COINS
            = new QueryChangesItemType("COINS");

        public static readonly QueryChangesItemType EXTENSION
            = new QueryChangesItemType("EXTENSION");

        public static readonly QueryChangesItemType INGAMEITEM
            = new QueryChangesItemType("INGAMEITEM");

        public static readonly QueryChangesItemType LOOTBOX
            = new QueryChangesItemType("LOOTBOX");

        public static readonly QueryChangesItemType MEDIA
            = new QueryChangesItemType("MEDIA");

        public static readonly QueryChangesItemType OPTIONBOX
            = new QueryChangesItemType("OPTIONBOX");

        public static readonly QueryChangesItemType SEASON
            = new QueryChangesItemType("SEASON");

        public static readonly QueryChangesItemType SUBSCRIPTION
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

    public class QueryChangesSortBy : StringEnum<QueryChangesSortBy>
    {
        public static readonly QueryChangesSortBy CreatedAt
            = new QueryChangesSortBy("createdAt");

        public static readonly QueryChangesSortBy CreatedAtasc
            = new QueryChangesSortBy("createdAt:asc");

        public static readonly QueryChangesSortBy CreatedAtdesc
            = new QueryChangesSortBy("createdAt:desc");

        public static readonly QueryChangesSortBy UpdatedAt
            = new QueryChangesSortBy("updatedAt");

        public static readonly QueryChangesSortBy UpdatedAtasc
            = new QueryChangesSortBy("updatedAt:asc");

        public static readonly QueryChangesSortBy UpdatedAtdesc
            = new QueryChangesSortBy("updatedAt:desc");


        public static implicit operator QueryChangesSortBy(string value)
        {
            return NewValue(value);
        }

        public QueryChangesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryChangesStatus : StringEnum<QueryChangesStatus>
    {
        public static readonly QueryChangesStatus PUBLISHED
            = new QueryChangesStatus("PUBLISHED");

        public static readonly QueryChangesStatus UNPUBLISHED
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
        public static readonly QueryChangesType CATEGORY
            = new QueryChangesType("CATEGORY");

        public static readonly QueryChangesType ITEM
            = new QueryChangesType("ITEM");

        public static readonly QueryChangesType SECTION
            = new QueryChangesType("SECTION");

        public static readonly QueryChangesType STORE
            = new QueryChangesType("STORE");

        public static readonly QueryChangesType VIEW
            = new QueryChangesType("VIEW");


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