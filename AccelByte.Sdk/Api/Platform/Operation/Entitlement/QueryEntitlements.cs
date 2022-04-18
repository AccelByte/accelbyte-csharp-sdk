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
    /// queryEntitlements
    ///
    /// Query entitlements.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : entitlement list
    /// </summary>
    public class QueryEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryEntitlementsBuilder Builder = new QueryEntitlementsBuilder();

        public class QueryEntitlementsBuilder
            : OperationBuilder<QueryEntitlementsBuilder>
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? AppType { get; set; }
            
            public string? EntitlementClazz { get; set; }
            
            public string? EntitlementName { get; set; }
            
            public List<string>? ItemId { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? UserId { get; set; }
            
            internal QueryEntitlementsBuilder() { }


            public QueryEntitlementsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryEntitlementsBuilder SetAppType(string _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryEntitlementsBuilder SetEntitlementClazz(string _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public QueryEntitlementsBuilder SetEntitlementName(string _entitlementName)
            {
                EntitlementName = _entitlementName;
                return this;
            }

            public QueryEntitlementsBuilder SetItemId(List<string> _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public QueryEntitlementsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryEntitlementsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryEntitlementsBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }




            public QueryEntitlements Build(
                string namespace_
            )
            {
                QueryEntitlements op = new QueryEntitlements(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryEntitlements(QueryEntitlementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.AppType != null) QueryParams["appType"] = builder.AppType;
            if (builder.EntitlementClazz != null) QueryParams["entitlementClazz"] = builder.EntitlementClazz;
            if (builder.EntitlementName != null) QueryParams["entitlementName"] = builder.EntitlementName;
            if (builder.ItemId != null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.UserId != null) QueryParams["userId"] = builder.UserId;
            
            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryEntitlements(
            string namespace_,            
            bool? activeOnly,            
            string? appType,            
            string? entitlementClazz,            
            string? entitlementName,            
            List<string>? itemId,            
            int? limit,            
            int? offset,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appType != null) QueryParams["appType"] = appType;
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (entitlementName != null) QueryParams["entitlementName"] = entitlementName;
            if (itemId != null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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