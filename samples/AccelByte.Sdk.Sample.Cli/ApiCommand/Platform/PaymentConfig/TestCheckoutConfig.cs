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
    [SdkConsoleCommand("platform","testcheckoutconfig")]
    public class TestCheckoutConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "TestCheckoutConfig"; } }

        [SdkCommandArgument("sandbox")]
        public bool? Sandbox { get; set; }

        [SdkCommandData("body")]
        public CheckoutConfig Body { get; set; } = new CheckoutConfig();
                
        public TestCheckoutConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            TestCheckoutConfig operation = new TestCheckoutConfig(
                Sandbox,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.TestResult? response = wrapper.TestCheckoutConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}