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
    [SdkConsoleCommand("chat", "admintopicmembers")]
    public class AdminTopicMembersCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminTopicMembers"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("topic")]
        public string Topic { get; set; } = String.Empty;

        [SdkCommandArgument("isBanned")]
        public bool? IsBanned { get; set; }

        [SdkCommandArgument("isModerator")]
        public bool? IsModerator { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("shardId")]
        public string? ShardId { get; set; }

        public AdminTopicMembersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminTopicMembers.Builder;

            if (IsBanned != null)
                opBuilder.SetIsBanned((bool)IsBanned);
            if (IsModerator != null)
                opBuilder.SetIsModerator((bool)IsModerator);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (ShardId != null)
                opBuilder.SetShardId((string)ShardId);




            AdminTopicMembers operation = opBuilder.Build(
                Namespace,
                Topic
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsTopicMemberWithPaginationResponse? response = wrapper.AdminTopicMembers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}