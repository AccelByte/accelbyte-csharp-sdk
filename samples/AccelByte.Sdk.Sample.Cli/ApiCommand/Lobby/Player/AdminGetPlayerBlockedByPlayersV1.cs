// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","admingetplayerblockedbyplayersv1")]
    public class AdminGetPlayerBlockedByPlayersV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminGetPlayerBlockedByPlayersV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminGetPlayerBlockedByPlayersV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Player wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Player(_SDK);

            AdminGetPlayerBlockedByPlayersV1 operation = new AdminGetPlayerBlockedByPlayersV1(
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelsGetAllPlayerBlockedByUsersResponse? response = wrapper.AdminGetPlayerBlockedByPlayersV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}