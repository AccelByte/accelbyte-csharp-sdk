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

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session", "admindeletebulkgamesessions")]
    public class AdminDeleteBulkGameSessionsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminDeleteBulkGameSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsDeleteBulkGameSessionRequest Body { get; set; } = new ApimodelsDeleteBulkGameSessionRequest();

        public AdminDeleteBulkGameSessionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.GameSession wrapper = new AccelByte.Sdk.Api.Session.Wrapper.GameSession(_SDK);

            AdminDeleteBulkGameSessions operation = new AdminDeleteBulkGameSessions(
                Namespace,
                Body
            );

            AccelByte.Sdk.Api.Session.Model.ApimodelsDeleteBulkGameSessionsAPIResponse? response = wrapper.AdminDeleteBulkGameSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}