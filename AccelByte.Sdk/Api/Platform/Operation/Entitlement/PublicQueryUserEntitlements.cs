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
        {
            
            
            public string? AppType { get; set; }
            
            public string? EntitlementClazz { get; set; }
            
            public string? EntitlementName { get; set; }
            
            public List<string>? ItemId { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            internal PublicQueryUserEntitlementsBuilder() { }


            public PublicQueryUserEntitlementsBuilder SetAppType(string _appType)
            {
                AppType = _appType;
                return this;
            }

            public PublicQueryUserEntitlementsBuilder SetEntitlementClazz(string _entitlementClazz)
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
                return new PublicQueryUserEntitlements(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicQueryUserEntitlements(PublicQueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AppType != null) QueryParams["appType"] = builder.AppType;
            if (builder.EntitlementClazz != null) QueryParams["entitlementClazz"] = builder.EntitlementClazz;
            if (builder.EntitlementName != null) QueryParams["entitlementName"] = builder.EntitlementName;
            if (builder.ItemId != null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            CollectionFormatMap["itemId"] = "multi";
            
            
        }
        #endregion

        public PublicQueryUserEntitlements(
            string namespace_,            
            string userId,            
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
            
            if (appType != null) QueryParams["appType"] = appType;
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (entitlementName != null) QueryParams["entitlementName"] = entitlementName;
            if (itemId != null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            CollectionFormatMap["itemId"] = "multi";
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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