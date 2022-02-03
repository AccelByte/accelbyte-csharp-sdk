using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking","publicgetmessages")]
    public class PublicGetMessagesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "PublicGetMessages"; } }

        public PublicGetMessagesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Operations(_SDK);

            PublicGetMessages operation = new PublicGetMessages(
            );            

            List<AccelByte.Sdk.Api.Matchmaking.Model.LogAppMessageDeclaration>? response = wrapper.PublicGetMessages(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}