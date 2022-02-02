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
    [SdkConsoleCommand("ugc","admingettag")]
    public class AdminGetTagCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminGetTag"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        public AdminGetTagCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag(_SDK);

            AdminGetTag operation = new AdminGetTag(
                Namespace,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedGetTagResponse? response = wrapper.AdminGetTag(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}