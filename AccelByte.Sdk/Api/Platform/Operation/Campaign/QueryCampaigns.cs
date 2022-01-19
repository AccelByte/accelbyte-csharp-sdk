using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class QueryCampaigns : AccelByte.Sdk.Core.Operation
    {
        public QueryCampaigns(
            string namespace_,            
            int? limit,            
            string? name,            
            int? offset,            
            string? tag            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tag != null) QueryParams["tag"] = tag;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/campaigns";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CampaignPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CampaignPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}