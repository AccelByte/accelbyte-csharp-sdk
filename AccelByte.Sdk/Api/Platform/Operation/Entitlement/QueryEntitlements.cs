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

            public QueryEntitlementsAppType? AppType { get; set; }

            public QueryEntitlementsEntitlementClazz? EntitlementClazz { get; set; }

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

            public QueryEntitlementsBuilder SetAppType(QueryEntitlementsAppType _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryEntitlementsBuilder SetEntitlementClazz(QueryEntitlementsEntitlementClazz _entitlementClazz)
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
            if (builder.AppType is not null) QueryParams["appType"] = builder.AppType.Value;
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (builder.EntitlementName is not null) QueryParams["entitlementName"] = builder.EntitlementName;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryEntitlements(
            string namespace_,            
            bool? activeOnly,            
            QueryEntitlementsAppType? appType,            
            QueryEntitlementsEntitlementClazz? entitlementClazz,            
            string? entitlementName,            
            List<string>? itemId,            
            int? limit,            
            int? offset,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appType is not null) QueryParams["appType"] = appType.Value;
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (entitlementName is not null) QueryParams["entitlementName"] = entitlementName;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (userId is not null) QueryParams["userId"] = userId;
            

            
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

    public class QueryEntitlementsAppType : StringEnum<QueryEntitlementsAppType>
    {
        public static readonly QueryEntitlementsAppType DEMO
            = new QueryEntitlementsAppType("DEMO");

        public static readonly QueryEntitlementsAppType DLC
            = new QueryEntitlementsAppType("DLC");

        public static readonly QueryEntitlementsAppType GAME
            = new QueryEntitlementsAppType("GAME");

        public static readonly QueryEntitlementsAppType SOFTWARE
            = new QueryEntitlementsAppType("SOFTWARE");


        public static implicit operator QueryEntitlementsAppType(string value)
        {
            return NewValue(value);
        }

        public QueryEntitlementsAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryEntitlementsEntitlementClazz : StringEnum<QueryEntitlementsEntitlementClazz>
    {
        public static readonly QueryEntitlementsEntitlementClazz APP
            = new QueryEntitlementsEntitlementClazz("APP");

        public static readonly QueryEntitlementsEntitlementClazz CODE
            = new QueryEntitlementsEntitlementClazz("CODE");

        public static readonly QueryEntitlementsEntitlementClazz ENTITLEMENT
            = new QueryEntitlementsEntitlementClazz("ENTITLEMENT");

        public static readonly QueryEntitlementsEntitlementClazz MEDIA
            = new QueryEntitlementsEntitlementClazz("MEDIA");

        public static readonly QueryEntitlementsEntitlementClazz SUBSCRIPTION
            = new QueryEntitlementsEntitlementClazz("SUBSCRIPTION");


        public static implicit operator QueryEntitlementsEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public QueryEntitlementsEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}