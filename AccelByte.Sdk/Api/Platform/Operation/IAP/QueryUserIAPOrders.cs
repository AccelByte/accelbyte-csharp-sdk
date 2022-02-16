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
    /// queryUserIAPOrders
    ///
    /// Query IAP orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:IAP", action=2 (READ)
    ///   *  Returns : paginated iap orders
    /// </summary>
    public class QueryUserIAPOrders : AccelByte.Sdk.Core.Operation
    {
        public QueryUserIAPOrders(
            string namespace_,            
            string userId,            
            string? endTime,            
            int? limit,            
            int? offset,            
            string? productId,            
            string? startTime,            
            string? status,            
            string? type            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (endTime != null) QueryParams["endTime"] = endTime;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (productId != null) QueryParams["productId"] = productId;
            if (startTime != null) QueryParams["startTime"] = startTime;
            if (status != null) QueryParams["status"] = status;
            if (type != null) QueryParams["type"] = type;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.IAPOrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}