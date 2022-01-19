using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    public class SingleAdminGetChannel : AccelByte.Sdk.Core.Operation
    {
        public SingleAdminGetChannel(
            string namespace_,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPaginatedGetChannelResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetChannelResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}