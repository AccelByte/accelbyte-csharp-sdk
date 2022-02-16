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
    [SdkConsoleCommand("lobby","adminupdateconfigv1")]
    public class AdminUpdateConfigV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminUpdateConfigV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsConfigReq Body { get; set; } = new ModelsConfigReq();
                
        public AdminUpdateConfigV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Config(_SDK);

            AdminUpdateConfigV1 operation = new AdminUpdateConfigV1(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelsConfigReq? response = wrapper.AdminUpdateConfigV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}