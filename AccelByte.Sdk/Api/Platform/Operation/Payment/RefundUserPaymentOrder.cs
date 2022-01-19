using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class RefundUserPaymentOrder : AccelByte.Sdk.Core.Operation
    {
        public RefundUserPaymentOrder(
            string namespace_,            
            string paymentOrderNo,            
            string userId,            
            Model.PaymentOrderRefund body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            PathParams["userId"] = userId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders/{paymentOrderNo}/refund";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentOrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}