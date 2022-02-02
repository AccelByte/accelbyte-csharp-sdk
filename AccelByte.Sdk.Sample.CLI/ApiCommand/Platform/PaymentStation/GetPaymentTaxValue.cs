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
    [SdkConsoleCommand("platform","getpaymenttaxvalue")]
    public class GetPaymentTaxValueCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetPaymentTaxValue"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("zipCode")]
        public string? ZipCode { get; set; }

        [SdkCommandArgument("paymentOrderNo")]
        public string PaymentOrderNo { get; set; }

        [SdkCommandArgument("paymentProvider")]
        public string PaymentProvider { get; set; }

        public GetPaymentTaxValueCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation(_SDK);

            GetPaymentTaxValue operation = new GetPaymentTaxValue(
                Namespace,                
                ZipCode,                
                PaymentOrderNo,                
                PaymentProvider                
            );            

            AccelByte.Sdk.Api.Platform.Model.TaxResult? response = wrapper.GetPaymentTaxValue(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}