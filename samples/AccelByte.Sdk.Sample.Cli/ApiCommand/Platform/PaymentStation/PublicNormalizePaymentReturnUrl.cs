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
    [SdkConsoleCommand("platform","publicnormalizepaymentreturnurl")]
    public class PublicNormalizePaymentReturnUrlCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicNormalizePaymentReturnUrl"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("payerID")]
        public string? PayerID { get; set; }

        [SdkCommandArgument("foreinginvoice")]
        public string? Foreinginvoice { get; set; }

        [SdkCommandArgument("invoiceId")]
        public string? InvoiceId { get; set; }

        [SdkCommandArgument("payload")]
        public string? Payload { get; set; }

        [SdkCommandArgument("resultCode")]
        public string? ResultCode { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("token")]
        public string? Token { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        [SdkCommandArgument("orderNo")]
        public string OrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("paymentOrderNo")]
        public string PaymentOrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("paymentProvider")]
        public string PaymentProvider { get; set; } = String.Empty;

        [SdkCommandArgument("returnUrl")]
        public string ReturnUrl { get; set; } = String.Empty;

        public PublicNormalizePaymentReturnUrlCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation(_SDK);

            PublicNormalizePaymentReturnUrl operation = new PublicNormalizePaymentReturnUrl(
                Namespace,                
                PayerID,                
                Foreinginvoice,                
                InvoiceId,                
                Payload,                
                ResultCode,                
                Status,                
                Token,                
                Type,                
                UserId,                
                OrderNo,                
                PaymentOrderNo,                
                PaymentProvider,                
                ReturnUrl                
            );            
            
            wrapper.PublicNormalizePaymentReturnUrl(operation);
            return String.Empty;
        }
    }
}