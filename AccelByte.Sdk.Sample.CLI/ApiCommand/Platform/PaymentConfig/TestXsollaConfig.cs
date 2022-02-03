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
    [SdkConsoleCommand("platform","testxsollaconfig")]
    public class TestXsollaConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "TestXsollaConfig"; } }

        [SdkCommandData("body")]
        public XsollaConfig? Body { get; set; }
                
        public TestXsollaConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            TestXsollaConfig operation = new TestXsollaConfig(
                Body                
            );            

            AccelByte.Sdk.Api.Platform.Model.TestResult? response = wrapper.TestXsollaConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}