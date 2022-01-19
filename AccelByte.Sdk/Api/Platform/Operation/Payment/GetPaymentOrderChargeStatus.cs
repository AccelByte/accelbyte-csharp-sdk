using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class GetPaymentOrderChargeStatus : AccelByte.Sdk.Core.Operation
    {
        public GetPaymentOrderChargeStatus(
            string namespace_,            
            string paymentOrderNo            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentOrderChargeStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderChargeStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}