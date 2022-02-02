using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","invalidateuserinfocache")]
    public class InvalidateUserInfoCacheCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "InvalidateUserInfoCache"; } }

        [SdkCommandArgument("namespace_")]
        public string? Namespace { get; set; }

        public InvalidateUserInfoCacheCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.UserInfo wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.UserInfo(_SDK);

            InvalidateUserInfoCache operation = new InvalidateUserInfoCache(
                Namespace                
            );            

            wrapper.InvalidateUserInfoCache(operation);
            return String.Empty;
        }
    }
}