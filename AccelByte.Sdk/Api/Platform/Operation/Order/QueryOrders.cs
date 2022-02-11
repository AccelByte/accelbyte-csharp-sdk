using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryOrders
    ///
    /// Query orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ORDER", action=2 (READ)
    ///   *  Returns : query orders
    /// </summary>
    public class QueryOrders : AccelByte.Sdk.Core.Operation
    {
        public QueryOrders(
            string namespace_,            
            string? endTime,            
            int? limit,            
            int? offset,            
            List<string>? orderNos,            
            string? sortBy,            
            string? startTime,            
            string? status,            
            bool? withTotal            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (endTime != null) QueryParams["endTime"] = endTime;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderNos != null) QueryParams["orderNos"] = orderNos;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (startTime != null) QueryParams["startTime"] = startTime;
            if (status != null) QueryParams["status"] = status;
            if (withTotal != null) QueryParams["withTotal"] = Convert.ToString(withTotal)!;
            
            
            CollectionFormatMap["orderNos"] = "multi";
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OrderPagingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}