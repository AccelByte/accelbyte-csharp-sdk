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
        public static QueryUserEntitlementsBuilder Builder { get => new QueryUserEntitlementsBuilder(); }

        public class QueryUserEntitlementsBuilder
            : OperationBuilder<QueryUserEntitlementsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public QueryUserEntitlementsAppType? AppType { get; set; }

            public QueryUserEntitlementsEntitlementClazz? EntitlementClazz { get; set; }

            public string? EntitlementName { get; set; }

            public List<string>? Features { get; set; }

            public List<string>? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryUserEntitlementsBuilder() { }


            public QueryUserEntitlementsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUserEntitlementsBuilder SetAppType(QueryUserEntitlementsAppType _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryUserEntitlementsBuilder SetEntitlementClazz(QueryUserEntitlementsEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public QueryUserEntitlementsBuilder SetEntitlementName(string _entitlementName)
            {
                EntitlementName = _entitlementName;
                return this;
            }

            public QueryUserEntitlementsBuilder SetFeatures(List<string> _features)
            {
                Features = _features;
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
            if (builder.AppType is not null) QueryParams["appType"] = builder.AppType.Value;
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (builder.EntitlementName is not null) QueryParams["entitlementName"] = builder.EntitlementName;
            if (builder.Features is not null) QueryParams["features"] = builder.Features;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            CollectionFormatMap["features"] = "multi";
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserEntitlements(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            QueryUserEntitlementsAppType? appType,            
            QueryUserEntitlementsEntitlementClazz? entitlementClazz,            
            string? entitlementName,            
            List<string>? features,            
            List<string>? itemId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appType is not null) QueryParams["appType"] = appType.Value;
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (entitlementName is not null) QueryParams["entitlementName"] = entitlementName;
            if (features is not null) QueryParams["features"] = features;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            CollectionFormatMap["features"] = "multi";
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

    public class QueryUserEntitlementsAppType : StringEnum<QueryUserEntitlementsAppType>
    {
        public static readonly QueryUserEntitlementsAppType DEMO
            = new QueryUserEntitlementsAppType("DEMO");

        public static readonly QueryUserEntitlementsAppType DLC
            = new QueryUserEntitlementsAppType("DLC");

        public static readonly QueryUserEntitlementsAppType GAME
            = new QueryUserEntitlementsAppType("GAME");

        public static readonly QueryUserEntitlementsAppType SOFTWARE
            = new QueryUserEntitlementsAppType("SOFTWARE");


        public static implicit operator QueryUserEntitlementsAppType(string value)
        {
            return NewValue(value);
        }

        public QueryUserEntitlementsAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryUserEntitlementsEntitlementClazz : StringEnum<QueryUserEntitlementsEntitlementClazz>
    {
        public static readonly QueryUserEntitlementsEntitlementClazz APP
            = new QueryUserEntitlementsEntitlementClazz("APP");

        public static readonly QueryUserEntitlementsEntitlementClazz CODE
            = new QueryUserEntitlementsEntitlementClazz("CODE");

        public static readonly QueryUserEntitlementsEntitlementClazz ENTITLEMENT
            = new QueryUserEntitlementsEntitlementClazz("ENTITLEMENT");

        public static readonly QueryUserEntitlementsEntitlementClazz LOOTBOX
            = new QueryUserEntitlementsEntitlementClazz("LOOTBOX");

        public static readonly QueryUserEntitlementsEntitlementClazz MEDIA
            = new QueryUserEntitlementsEntitlementClazz("MEDIA");

        public static readonly QueryUserEntitlementsEntitlementClazz OPTIONBOX
            = new QueryUserEntitlementsEntitlementClazz("OPTIONBOX");

        public static readonly QueryUserEntitlementsEntitlementClazz SUBSCRIPTION
            = new QueryUserEntitlementsEntitlementClazz("SUBSCRIPTION");


        public static implicit operator QueryUserEntitlementsEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public QueryUserEntitlementsEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}