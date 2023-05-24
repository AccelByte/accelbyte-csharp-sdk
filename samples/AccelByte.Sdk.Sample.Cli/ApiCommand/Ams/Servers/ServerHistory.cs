// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams", "serverhistory")]
    public class ServerHistoryCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Ams"; } }

        public string OperationName { get { return "ServerHistory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("serverID")]
        public string ServerID { get; set; } = String.Empty;

        public ServerHistoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Servers wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Servers(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.ServerHistory.Builder;





            ServerHistory operation = opBuilder.Build(
                Namespace,
                ServerID
            );


            AccelByte.Sdk.Api.Ams.Model.ApiFleetServerHistoryResponse? response = wrapper.ServerHistory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}