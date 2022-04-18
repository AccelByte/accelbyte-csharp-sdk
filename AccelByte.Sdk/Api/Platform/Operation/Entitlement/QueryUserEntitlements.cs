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
    /// queryUserEntitlements
    ///
    /// Query entitlements for a specific user.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : entitlement list
    /// </summary>
    public class QueryUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserEntitlementsBuilder Builder = new QueryUserEntitlementsBuilder();

        public class QueryUserEntitlementsBuilder
            : OperationBuilder<QueryUserEntitlementsBuilder>
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            public string? AppType { get; set; }
            
            public string? EntitlementClazz { get; set; }
            
            public string? EntitlementName { get; set; }
            
            public List<string>? ItemId { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            internal QueryUserEntitlementsBuilder() { }


            public QueryUserEntitlementsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUserEntitlementsBuilder SetAppType(string _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryUserEntitlementsBuilder SetEntitlementClazz(string _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public QueryUserEntitlementsBuilder SetEntitlementName(string _entitlementName)
            {
                EntitlementName = _entitlementName;
                return this;
            }

            public QueryUserEntitlementsBuilder SetItemId(List<string> _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public QueryUserEntitlementsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserEntitlementsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public QueryUserEntitlements Build(
                string namespace_,
                string userId
            )
            {
                QueryUserEntitlements op = new QueryUserEntitlements(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryUserEntitlements(QueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.AppType != null) QueryParams["appType"] = builder.AppType;
            if (builder.EntitlementClazz != null) QueryParams["entitlementClazz"] = builder.EntitlementClazz;
            if (builder.EntitlementName != null) QueryParams["entitlementName"] = builder.EntitlementName;
            if (builder.ItemId != null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserEntitlements(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            string? appType,            
            string? entitlementClazz,            
            string? entitlementName,            
            List<string>? itemId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appType != null) QueryParams["appType"] = appType;
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (entitlementName != null) QueryParams["entitlementName"] = entitlementName;
            if (itemId != null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements";

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