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
    /// queryEntitlements_1
    ///
    /// Query entitlements by Item Ids.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : entitlement list
    /// </summary>
    public class QueryEntitlements1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryEntitlements1Builder Builder { get => new QueryEntitlements1Builder(); }

        public class QueryEntitlements1Builder
            : OperationBuilder<QueryEntitlements1Builder>
        {

            public bool? ActiveOnly { get; set; }

            public List<string>? ItemIds { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryEntitlements1Builder() { }


            public QueryEntitlements1Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryEntitlements1Builder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public QueryEntitlements1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryEntitlements1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryEntitlements1 Build(
                string namespace_
            )
            {
                QueryEntitlements1 op = new QueryEntitlements1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryEntitlements1(QueryEntitlements1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.ItemIds is not null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;



            CollectionFormatMap["itemIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryEntitlements1(
            string namespace_,
            bool? activeOnly,
            List<string>? itemIds,
            int? limit,
            int? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;



            CollectionFormatMap["itemIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements/byItemIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementPagingSlicedResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}