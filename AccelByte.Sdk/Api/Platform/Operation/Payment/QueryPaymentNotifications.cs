using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class QueryPaymentNotifications : AccelByte.Sdk.Core.Operation
    {
        public QueryPaymentNotifications(
            string namespace_,            
            string? endDate,            
            string? externalId,            
            int? limit,            
            string? notificationSource,            
            string? notificationType,            
            int? offset,            
            string? paymentOrderNo,            
            string? startDate,            
            string? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (externalId != null) QueryParams["externalId"] = externalId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (notificationSource != null) QueryParams["notificationSource"] = notificationSource;
            if (notificationType != null) QueryParams["notificationType"] = notificationType;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (startDate != null) QueryParams["startDate"] = startDate;
            if (status != null) QueryParams["status"] = status;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/notifications";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentNotificationPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentNotificationPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}