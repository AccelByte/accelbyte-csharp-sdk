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
    [SdkConsoleCommand("ugc","singleadmingetallgroups")]
    public class SingleAdminGetAllGroupsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "SingleAdminGetAllGroups"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        public SingleAdminGetAllGroupsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminGroup wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminGroup(_SDK);

            SingleAdminGetAllGroups operation = new SingleAdminGetAllGroups(
                Namespace,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedGroupResponse? response = wrapper.SingleAdminGetAllGroups(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}