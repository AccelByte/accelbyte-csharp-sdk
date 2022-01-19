using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class DeleteCurrency : AccelByte.Sdk.Core.Operation
    {
        public DeleteCurrency(
            string currencyCode,            
            string namespace_            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CurrencyInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencyInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}