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
    [SdkConsoleCommand("ugc","singleadmingetchannel")]
    public class SingleAdminGetChannelCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "SingleAdminGetChannel"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        public SingleAdminGetChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminChannel wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminChannel(_SDK);

            SingleAdminGetChannel operation = new SingleAdminGetChannel(
                Namespace,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedGetChannelResponse? response = wrapper.SingleAdminGetChannel(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}