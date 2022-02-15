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
    [SdkConsoleCommand("ugc","admincreategroup")]
    public class AdminCreateGroupCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminCreateGroup"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateGroupRequest Body { get; set; } = new ModelsCreateGroupRequest();
                
        public AdminCreateGroupCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminGroup wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminGroup(_SDK);

            AdminCreateGroup operation = new AdminCreateGroup(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateGroupResponse? response = wrapper.AdminCreateGroup(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}