using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class QueryCodes : AccelByte.Sdk.Core.Operation
    {
        public QueryCodes(
            string campaignId,            
            string namespace_,            
            bool? activeOnly,            
            int? batchNo,            
            string? code,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (batchNo != null) QueryParams["batchNo"] = Convert.ToString(batchNo)!;
            if (code != null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CodeInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}