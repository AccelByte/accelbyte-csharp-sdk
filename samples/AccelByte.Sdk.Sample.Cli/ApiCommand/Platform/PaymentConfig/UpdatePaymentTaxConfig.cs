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
    [SdkConsoleCommand("platform","updatepaymenttaxconfig")]
    public class UpdatePaymentTaxConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdatePaymentTaxConfig"; } }

        [SdkCommandData("body")]
        public PaymentTaxConfigEdit Body { get; set; } = new PaymentTaxConfigEdit();
                
        public UpdatePaymentTaxConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            UpdatePaymentTaxConfig operation = new UpdatePaymentTaxConfig(
                Body                
            );            

            AccelByte.Sdk.Api.Platform.Model.PaymentTaxConfigInfo? response = wrapper.UpdatePaymentTaxConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}