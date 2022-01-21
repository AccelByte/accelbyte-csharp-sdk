using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class GetPaymentTaxValue : AccelByte.Sdk.Core.Operation
    {
        public GetPaymentTaxValue(
            string namespace_,            
            string? zipCode,            
            string paymentOrderNo,            
            string paymentProvider            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (zipCode != null) QueryParams["zipCode"] = zipCode;
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/tax";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.TaxResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TaxResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}