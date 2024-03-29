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

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby", "notificationwithtemplate")]
    public class NotificationWithTemplateCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "NotificationWithTemplate"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelNotificationWithTemplateRequest Body { get; set; } = new ModelNotificationWithTemplateRequest();

        public NotificationWithTemplateCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Admin wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Admin(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.NotificationWithTemplate.Builder;





            NotificationWithTemplate operation = opBuilder.Build(
                Body,
                Namespace
            );


            wrapper.NotificationWithTemplate(operation);
            return String.Empty;
        }
    }
}