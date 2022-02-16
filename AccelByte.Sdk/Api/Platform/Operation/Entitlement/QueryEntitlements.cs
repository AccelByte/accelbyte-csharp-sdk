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
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements";

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