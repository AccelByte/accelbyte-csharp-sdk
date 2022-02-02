using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","getbannedusers")]
    public class GetBannedUsersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "GetBannedUsers"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userIds")]
        public List<string> UserIds { get; set; }

        public GetBannedUsersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.UserAction wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.UserAction(_SDK);

            GetBannedUsers operation = new GetBannedUsers(
                Namespace,                
                UserIds                
            );            

            List<AccelByte.Sdk.Api.Basic.Model.ADTOObjectForEqu8UserBanStatus>? response = wrapper.GetBannedUsers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}