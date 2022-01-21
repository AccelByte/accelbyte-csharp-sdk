using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class ListExtOrderNoByExtTxId : AccelByte.Sdk.Core.Operation
    {
        public ListExtOrderNoByExtTxId(
            string namespace_,            
            string extTxId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (extTxId != null) QueryParams["extTxId"] = extTxId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/byExtTxId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}