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
    [SdkConsoleCommand("platform","testfulfillmentscripteval")]
    public class TestFulfillmentScriptEvalCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "TestFulfillmentScriptEval"; } }

        [SdkCommandData("body")]
        public FulfillmentScriptEvalTestRequest Body { get; set; } = new FulfillmentScriptEvalTestRequest();
                
        public TestFulfillmentScriptEvalCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.FulfillmentScript wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.FulfillmentScript(_SDK);

            TestFulfillmentScriptEval operation = new TestFulfillmentScriptEval(
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.FulfillmentScriptEvalTestResult? response = wrapper.TestFulfillmentScriptEval(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}