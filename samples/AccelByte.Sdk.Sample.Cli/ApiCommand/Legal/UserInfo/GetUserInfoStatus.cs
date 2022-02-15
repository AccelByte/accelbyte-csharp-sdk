using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","getuserinfostatus")]
    public class GetUserInfoStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "GetUserInfoStatus"; } }

        [SdkCommandArgument("namespaces")]
        public string? Namespaces { get; set; }

        public GetUserInfoStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.UserInfo wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.UserInfo(_SDK);

            GetUserInfoStatus operation = new GetUserInfoStatus(
                Namespaces                
            );            
            
            List<AccelByte.Sdk.Api.Legal.Model.RetrieveUserInfoCacheStatusResponse>? response = wrapper.GetUserInfoStatus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}