using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group","getgrouplistadminv1")]
    public class GetGroupListAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "GetGroupListAdminV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("configurationCode")]
        public string? ConfigurationCode { get; set; }

        [SdkCommandArgument("groupName")]
        public string? GroupName { get; set; }

        [SdkCommandArgument("groupRegion")]
        public string? GroupRegion { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetGroupListAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            GetGroupListAdminV1 operation = new GetGroupListAdminV1(
                Namespace,                
                ConfigurationCode,                
                GroupName,                
                GroupRegion,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsGetGroupsListResponseV1? response = wrapper.GetGroupListAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}