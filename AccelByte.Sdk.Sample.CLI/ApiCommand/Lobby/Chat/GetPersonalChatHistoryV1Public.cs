using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","getpersonalchathistoryv1public")]
    public class GetPersonalChatHistoryV1PublicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "GetPersonalChatHistoryV1Public"; } }

        [SdkCommandArgument("friendId")]
        public string FriendId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetPersonalChatHistoryV1PublicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Chat wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Chat(_SDK);

            GetPersonalChatHistoryV1Public operation = new GetPersonalChatHistoryV1Public(
                FriendId,                
                Namespace                
            );            

            List<AccelByte.Sdk.Api.Lobby.Model.ModelChatMessageResponse>? response = wrapper.GetPersonalChatHistoryV1Public(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}