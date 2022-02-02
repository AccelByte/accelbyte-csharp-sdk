using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","adminupdatetag")]
    public class AdminUpdateTagCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminUpdateTag"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("tagId")]
        public string TagId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateTagRequest? Body { get; set; }
                
        public AdminUpdateTagCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag(_SDK);

            AdminUpdateTag operation = new AdminUpdateTag(
                Namespace,                
                TagId,                
                Body                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateTagResponse? response = wrapper.AdminUpdateTag(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}