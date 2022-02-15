using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","admincreatetag")]
    public class AdminCreateTagCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminCreateTag"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateTagRequest Body { get; set; } = new ModelsCreateTagRequest();
                
        public AdminCreateTagCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag(_SDK);

            AdminCreateTag operation = new AdminCreateTag(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateTagResponse? response = wrapper.AdminCreateTag(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}