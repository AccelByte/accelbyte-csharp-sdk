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
    [SdkConsoleCommand("platform","createpaymentproviderconfig")]
    public class CreatePaymentProviderConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CreatePaymentProviderConfig"; } }

        [SdkCommandData("body")]
        public PaymentProviderConfigEdit? Body { get; set; }
                
        public CreatePaymentProviderConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            CreatePaymentProviderConfig operation = new CreatePaymentProviderConfig(
                Body                
            );            

            AccelByte.Sdk.Api.Platform.Model.PaymentProviderConfigInfo? response = wrapper.CreatePaymentProviderConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}