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
    [SdkConsoleCommand("legal","syncuserinfo")]
    public class SyncUserInfoCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "SyncUserInfo"; } }

        [SdkCommandArgument("namespace_")]
        public string Namespace { get; set; } = String.Empty;

        public SyncUserInfoCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.UserInfo wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.UserInfo(_SDK);

            SyncUserInfo operation = new SyncUserInfo(
                Namespace                
            );            

            wrapper.SyncUserInfo(operation);
            return String.Empty;
        }
    }
}