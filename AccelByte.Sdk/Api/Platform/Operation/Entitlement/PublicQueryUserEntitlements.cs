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
    /// publicQueryUserEntitlements
    ///
    /// Query user entitlements for a specific user.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : entitlement list
    /// </summary>
    public class PublicQueryUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserEntitlementsBuilder Builder = new PublicQueryUserEntitlementsBuilder();

        public class PublicQueryUserEntitlementsBuilder
            : OperationBuilder<PublicQueryUserEntitlementsBuilder>
        {

            public PublicQueryUserEntitlementsAppType? AppType { get; set; }

            public PublicQueryUserEntitlementsEntitlementClazz? EntitlementClazz { get; set; }

            public string? EntitlementName { get; set; }

            public List<string>? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal PublicQueryUserEntitlementsBuilder() { }


            public PublicQueryUserEntitlementsBuilder SetAppType(PublicQueryUserEntitlementsAppType _appType)
            {
                AppType = _appType;
                return this;
            }

            public PublicQueryUserEntitlementsBuilder SetEntitlementClazz(PublicQueryUserEntitlementsEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }

            public PublicQueryUserEntitlementsBuilder SetEntitlementName(string _entitlementName)
            {
                EntitlementName = _entitlementName;
                return this;
            }

            public PublicQueryUserEntitlementsBuilder SetItemId(List<string> _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public PublicQueryUserEntitlementsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserEntitlementsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public PublicQueryUserEntitlements Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserEntitlements op = new PublicQueryUserEntitlements(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicQueryUserEntitlements(PublicQueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AppType is not null) QueryParams["appType"] = builder.AppType.Value;
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (builder.EntitlementName is not null) QueryParams["entitlementName"] = builder.EntitlementName;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserEntitlements(
            string namespace_,            
            string userId,            
            PublicQueryUserEntitlementsAppType? appType,            
            PublicQueryUserEntitlementsEntitlementClazz? entitlementClazz,            
            string? entitlementName,            
            List<string>? itemId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appType is not null) QueryParams["appType"] = appType.Value;
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (entitlementName is not null) QueryParams["entitlementName"] = entitlementName;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            CollectionFormatMap["itemId"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements";

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

    public class PublicQueryUserEntitlementsAppType : StringEnum<PublicQueryUserEntitlementsAppType>
    {
        public static readonly PublicQueryUserEntitlementsAppType DEMO
            = new PublicQueryUserEntitlementsAppType("DEMO");

        public static readonly PublicQueryUserEntitlementsAppType DLC
            = new PublicQueryUserEntitlementsAppType("DLC");

        public static readonly PublicQueryUserEntitlementsAppType GAME
            = new PublicQueryUserEntitlementsAppType("GAME");

        public static readonly PublicQueryUserEntitlementsAppType SOFTWARE
            = new PublicQueryUserEntitlementsAppType("SOFTWARE");


        public static implicit operator PublicQueryUserEntitlementsAppType(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserEntitlementsAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PublicQueryUserEntitlementsEntitlementClazz : StringEnum<PublicQueryUserEntitlementsEntitlementClazz>
    {
        public static readonly PublicQueryUserEntitlementsEntitlementClazz APP
            = new PublicQueryUserEntitlementsEntitlementClazz("APP");

        public static readonly PublicQueryUserEntitlementsEntitlementClazz CODE
            = new PublicQueryUserEntitlementsEntitlementClazz("CODE");

        public static readonly PublicQueryUserEntitlementsEntitlementClazz ENTITLEMENT
            = new PublicQueryUserEntitlementsEntitlementClazz("ENTITLEMENT");

        public static readonly PublicQueryUserEntitlementsEntitlementClazz MEDIA
            = new PublicQueryUserEntitlementsEntitlementClazz("MEDIA");

        public static readonly PublicQueryUserEntitlementsEntitlementClazz SUBSCRIPTION
            = new PublicQueryUserEntitlementsEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicQueryUserEntitlementsEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserEntitlementsEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}