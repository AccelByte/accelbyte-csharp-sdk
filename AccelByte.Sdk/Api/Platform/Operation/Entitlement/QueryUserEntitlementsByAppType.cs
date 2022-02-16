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
    /// queryUserEntitlementsByAppType
    ///
    /// Query app entitlements by appType.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2
    ///   *  Returns : app entitlement pagination
    /// </summary>
    public class QueryUserEntitlementsByAppType : AccelByte.Sdk.Core.Operation
    {
        public QueryUserEntitlementsByAppType(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            int? limit,            
            int? offset,            
            string appType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (appType != null) QueryParams["appType"] = appType;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AppEntitlementPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}