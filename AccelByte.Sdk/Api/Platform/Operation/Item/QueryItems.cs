using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryItems
    ///
    /// This API is used to query items by criteria within a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of items
    /// </summary>
    public class QueryItems : AccelByte.Sdk.Core.Operation
    {
        public QueryItems(
            string namespace_,            
            bool? activeOnly,            
            string? appType,            
            string? availableDate,            
            string? baseAppId,            
            string? categoryPath,            
            string? features,            
            string? itemType,            
            int? limit,            
            int? offset,            
            string? region,            
            string? sortBy,            
            string? storeId,            
            string? tags,            
            string? targetNamespace            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appType != null) QueryParams["appType"] = appType;
            if (availableDate != null) QueryParams["availableDate"] = availableDate;
            if (baseAppId != null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath != null) QueryParams["categoryPath"] = categoryPath;
            if (features != null) QueryParams["features"] = features;
            if (itemType != null) QueryParams["itemType"] = itemType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (tags != null) QueryParams["tags"] = tags;
            if (targetNamespace != null) QueryParams["targetNamespace"] = targetNamespace;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FullItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}