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
    [SdkConsoleCommand("platform","updatepaymentcallbackconfig")]
    public class UpdatePaymentCallbackConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdatePaymentCallbackConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PaymentCallbackConfigUpdate Body { get; set; } = new PaymentCallbackConfigUpdate();
                
        public UpdatePaymentCallbackConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentCallbackConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentCallbackConfig(_SDK);

            UpdatePaymentCallbackConfig operation = new UpdatePaymentCallbackConfig(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.PaymentCallbackConfigInfo? response = wrapper.UpdatePaymentCallbackConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}