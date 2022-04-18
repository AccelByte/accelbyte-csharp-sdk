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
        #region Builder Part
        public static QueryPaymentNotificationsBuilder Builder = new QueryPaymentNotificationsBuilder();

        public class QueryPaymentNotificationsBuilder
            : OperationBuilder<QueryPaymentNotificationsBuilder>
        {
            
            public string? EndDate { get; set; }
            
            public string? ExternalId { get; set; }
            
            public int? Limit { get; set; }
            
            public string? NotificationSource { get; set; }
            
            public string? NotificationType { get; set; }
            
            public int? Offset { get; set; }
            
            public string? PaymentOrderNo { get; set; }
            
            public string? StartDate { get; set; }
            
            public string? Status { get; set; }
            
            internal QueryPaymentNotificationsBuilder() { }


            public QueryPaymentNotificationsBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetExternalId(string _externalId)
            {
                ExternalId = _externalId;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetNotificationSource(string _notificationSource)
            {
                NotificationSource = _notificationSource;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetNotificationType(string _notificationType)
            {
                NotificationType = _notificationType;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetPaymentOrderNo(string _paymentOrderNo)
            {
                PaymentOrderNo = _paymentOrderNo;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }




            public QueryPaymentNotifications Build(
                string namespace_
            )
            {
                QueryPaymentNotifications op = new QueryPaymentNotifications(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryPaymentNotifications(QueryPaymentNotificationsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EndDate != null) QueryParams["endDate"] = builder.EndDate;
            if (builder.ExternalId != null) QueryParams["externalId"] = builder.ExternalId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.NotificationSource != null) QueryParams["notificationSource"] = builder.NotificationSource;
            if (builder.NotificationType != null) QueryParams["notificationType"] = builder.NotificationType;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PaymentOrderNo != null) QueryParams["paymentOrderNo"] = builder.PaymentOrderNo;
            if (builder.StartDate != null) QueryParams["startDate"] = builder.StartDate;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

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
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/notifications";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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