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
    [SdkConsoleCommand("platform","deletefulfillmentscript")]
    public class DeleteFulfillmentScriptCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DeleteFulfillmentScript"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        public DeleteFulfillmentScriptCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.FulfillmentScript wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.FulfillmentScript(_SDK);

            DeleteFulfillmentScript operation = new DeleteFulfillmentScript(
                Id                
            );            

            wrapper.DeleteFulfillmentScript(operation);
            return String.Empty;
        }
    }
}