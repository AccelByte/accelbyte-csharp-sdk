using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","querypaymentnotifications")]
    public class QueryPaymentNotificationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryPaymentNotifications"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("externalId")]
        public string? ExternalId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("notificationSource")]
        public string? NotificationSource { get; set; }

        [SdkCommandArgument("notificationType")]
        public string? NotificationType { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public QueryPaymentNotificationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Payment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Payment(_SDK);

            QueryPaymentNotifications operation = new QueryPaymentNotifications(
                Namespace,                
                EndDate,                
                ExternalId,                
                Limit,                
                NotificationSource,                
                NotificationType,                
                Offset,                
                PaymentOrderNo,                
                StartDate,                
                Status                
            );            

            AccelByte.Sdk.Api.Platform.Model.PaymentNotificationPagingSlicedResult? response = wrapper.QueryPaymentNotifications(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}