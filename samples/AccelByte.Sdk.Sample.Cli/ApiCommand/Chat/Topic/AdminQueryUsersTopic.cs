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
    [SdkConsoleCommand("chat", "adminqueryuserstopic")]
    public class AdminQueryUsersTopicCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminQueryUsersTopic"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("includePastTopics")]
        public bool? IncludePastTopics { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("topicSubType")]
        public string? TopicSubType { get; set; }

        [SdkCommandArgument("topicType")]
        public string? TopicType { get; set; }

        public AdminQueryUsersTopicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminQueryUsersTopic.Builder;

            if (IncludePastTopics != null)
                opBuilder.SetIncludePastTopics((bool)IncludePastTopics);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (TopicSubType != null)
                opBuilder.SetTopicSubType(AdminQueryUsersTopicTopicSubType.NewValue(TopicSubType));
            if (TopicType != null)
                opBuilder.SetTopicType(AdminQueryUsersTopicTopicType.NewValue(TopicType));




            AdminQueryUsersTopic operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsTopicLogWithPaginationResponse? response = wrapper.AdminQueryUsersTopic(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}