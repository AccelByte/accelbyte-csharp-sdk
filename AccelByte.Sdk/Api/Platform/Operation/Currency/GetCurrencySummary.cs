using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class GetCurrencySummary : AccelByte.Sdk.Core.Operation
    {
        public GetCurrencySummary(
            string currencyCode,            
            string namespace_            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/summary";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CurrencySummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencySummary>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}