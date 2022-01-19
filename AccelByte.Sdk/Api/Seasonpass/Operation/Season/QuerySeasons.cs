using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    public class QuerySeasons : AccelByte.Sdk.Core.Operation
    {
        public QuerySeasons(
            string namespace_,            
            int? limit,            
            int? offset,            
            List<string>? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status != null) QueryParams["status"] = Convert.ToString(status)!;
            
            
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ListSeasonInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ListSeasonInfoPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}