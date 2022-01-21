using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class PublicQueryItems : AccelByte.Sdk.Core.Operation
    {
        public PublicQueryItems(
            string namespace_,            
            string? appType,            
            string? baseAppId,            
            string? categoryPath,            
            string? features,            
            string? itemType,            
            string? language,            
            int? limit,            
            int? offset,            
            string? region,            
            string? sortBy,            
            string? storeId,            
            string? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appType != null) QueryParams["appType"] = appType;
            if (baseAppId != null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath != null) QueryParams["categoryPath"] = categoryPath;
            if (features != null) QueryParams["features"] = features;
            if (itemType != null) QueryParams["itemType"] = itemType;
            if (language != null) QueryParams["language"] = language;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (tags != null) QueryParams["tags"] = tags;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}