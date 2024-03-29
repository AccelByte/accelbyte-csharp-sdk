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

using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Chat
{
    [SdkConsoleCommand("chat", "admingetinboxusers")]
    public class AdminGetInboxUsersCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminGetInboxUsers"; } }

        [SdkCommandArgument("inbox")]
        public string Inbox { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminGetInboxUsersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Inbox wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Inbox(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminGetInboxUsers.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Status != null)
                opBuilder.SetStatus(AdminGetInboxUsersStatus.NewValue(Status));
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminGetInboxUsers operation = opBuilder.Build(
                Inbox,
                Namespace
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsGetInboxUsersResponse? response = wrapper.AdminGetInboxUsers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}