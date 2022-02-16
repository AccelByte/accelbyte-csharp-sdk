// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryPaymentNotifications
    ///
    /// Query payment notifications.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT:NOTIFICATION", action=2 (READ)
    ///   *  Returns : Payment notifications
    /// </summary>
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
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentNotificationPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentNotificationPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}