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
    [SdkConsoleCommand("platform","getkeygroupdynamic")]
    public class GetKeyGroupDynamicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetKeyGroupDynamic"; } }

        [SdkCommandArgument("keyGroupId")]
        public string KeyGroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetKeyGroupDynamicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.KeyGroup wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.KeyGroup(_SDK);

            GetKeyGroupDynamic operation = new GetKeyGroupDynamic(
                KeyGroupId,                
                Namespace                
            );            

            AccelByte.Sdk.Api.Platform.Model.KeyGroupDynamicInfo? response = wrapper.GetKeyGroupDynamic(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}