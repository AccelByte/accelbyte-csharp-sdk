using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","refunduserpaymentorder")]
    public class RefundUserPaymentOrderCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "RefundUserPaymentOrder"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("paymentOrderNo")]
        public string PaymentOrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PaymentOrderRefund Body { get; set; } = new PaymentOrderRefund();
                
        public RefundUserPaymentOrderCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Payment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Payment(_SDK);

            RefundUserPaymentOrder operation = new RefundUserPaymentOrder(
                Namespace,                
                PaymentOrderNo,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.PaymentOrderInfo? response = wrapper.RefundUserPaymentOrder(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}