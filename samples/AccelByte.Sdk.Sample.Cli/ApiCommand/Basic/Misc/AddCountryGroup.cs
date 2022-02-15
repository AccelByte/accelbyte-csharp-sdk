using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","addcountrygroup")]
    public class AddCountryGroupCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "AddCountryGroup"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public AddCountryGroupRequest Body { get; set; } = new AddCountryGroupRequest();
                
        public AddCountryGroupCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Misc wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Misc(_SDK);

            AddCountryGroup operation = new AddCountryGroup(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Basic.Model.AddCountryGroupResponse? response = wrapper.AddCountryGroup(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}