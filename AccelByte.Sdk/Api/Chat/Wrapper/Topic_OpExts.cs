// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ChatTopic_OpExts
    {
        public static Chat.Model.ModelsChatMessageWithPaginationResponse? Execute(
            this AdminChatHistory.AdminChatHistoryBuilder builder,
            string namespace_
        )
        {
            AdminChatHistory op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminChatHistory(op);
        }
        public static Chat.Model.ApiCreateTopicResponse? Execute(
            this AdminCreateNamespaceTopic.AdminCreateNamespaceTopicBuilder builder,
            ApiCreateNamespaceTopicParams body,
            string namespace_
        )
        {
            AdminCreateNamespaceTopic op = builder.Build(
                body,
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminCreateNamespaceTopic(op);
        }
        public static List<Chat.Model.ModelsTopicResponse>? Execute(
            this AdminTopicList.AdminTopicListBuilder builder,
            string namespace_
        )
        {
            AdminTopicList op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminTopicList(op);
        }
        public static Chat.Model.ApiCreateTopicResponse? Execute(
            this AdminCreateTopic.AdminCreateTopicBuilder builder,
            ApiCreateTopicParams body,
            string namespace_
        )
        {
            AdminCreateTopic op = builder.Build(
                body,
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminCreateTopic(op);
        }
        public static Chat.Model.ModelsChannelTopicWithPaginationResponse? Execute(
            this AdminChannelTopicList.AdminChannelTopicListBuilder builder,
            string namespace_
        )
        {
            AdminChannelTopicList op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminChannelTopicList(op);
        }
        public static Chat.Model.ModelsChannelTopicSummaryResponse? Execute(
            this AdminChannelTopicSummary.AdminChannelTopicSummaryBuilder builder,
            string namespace_
        )
        {
            AdminChannelTopicSummary op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminChannelTopicSummary(op);
        }
        public static Chat.Model.ModelsTopicLogWithPaginationResponse? Execute(
            this AdminQueryTopicLog.AdminQueryTopicLogBuilder builder,
            string namespace_
        )
        {
            AdminQueryTopicLog op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminQueryTopicLog(op);
        }
        public static Chat.Model.ApiCreateTopicResponse? Execute(
            this AdminUpdateTopic.AdminUpdateTopicBuilder builder,
            ApiUpdateTopicParams body,
            string namespace_,
            string topic
        )
        {
            AdminUpdateTopic op = builder.Build(
                body,
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminUpdateTopic(op);
        }
        public static Chat.Model.MessageActionDeleteTopicResult? Execute(
            this AdminDeleteTopic.AdminDeleteTopicBuilder builder,
            string namespace_,
            string topic
        )
        {
            AdminDeleteTopic op = builder.Build(
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminDeleteTopic(op);
        }
        public static Chat.Model.ModelsBanTopicMemberResult? Execute(
            this AdminBanTopicMembers.AdminBanTopicMembersBuilder builder,
            ModelsBanTopicMemberParam body,
            string namespace_,
            string topic
        )
        {
            AdminBanTopicMembers op = builder.Build(
                body,
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminBanTopicMembers(op);
        }
        public static Chat.Model.ModelsChannelTopicResponse? Execute(
            this AdminChannelTopicInfo.AdminChannelTopicInfoBuilder builder,
            string namespace_,
            string topic
        )
        {
            AdminChannelTopicInfo op = builder.Build(
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminChannelTopicInfo(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Chat.Model.ModelsChatMessageWithPaginationResponse? Execute(
            this AdminTopicChatHistory.AdminTopicChatHistoryBuilder builder,
            string namespace_,
            string topic
        )
        {
            AdminTopicChatHistory op = builder.Build(
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminTopicChatHistory(op);
        }
        public static List<Chat.Model.ModelsChatMessageResponse>? Execute(
            this AdminSendChat.AdminSendChatBuilder builder,
            ApiSendChatParams body,
            string namespace_,
            string topic
        )
        {
            AdminSendChat op = builder.Build(
                body,
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminSendChat(op);
        }
        public static void Execute(
            this AdminDeleteChat.AdminDeleteChatBuilder builder,
            string chatId,
            string namespace_,
            string topic
        )
        {
            AdminDeleteChat op = builder.Build(
                chatId,
                namespace_,
                topic
            );

            ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminDeleteChat(op);
        }
        public static Chat.Model.ModelsTopicMemberWithPaginationResponse? Execute(
            this AdminTopicMembers.AdminTopicMembersBuilder builder,
            string namespace_,
            string topic
        )
        {
            AdminTopicMembers op = builder.Build(
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminTopicMembers(op);
        }
        public static List<string>? Execute(
            this AdminTopicShards.AdminTopicShardsBuilder builder,
            string namespace_,
            string topic
        )
        {
            AdminTopicShards op = builder.Build(
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminTopicShards(op);
        }
        public static Chat.Model.ModelsUnbanTopicMemberResult? Execute(
            this AdminUnbanTopicMembers.AdminUnbanTopicMembersBuilder builder,
            ModelsUnbanTopicMemberParam body,
            string namespace_,
            string topic
        )
        {
            AdminUnbanTopicMembers op = builder.Build(
                body,
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminUnbanTopicMembers(op);
        }
        public static Chat.Model.MessageActionAddUserToTopicResult? Execute(
            this AdminAddTopicMember.AdminAddTopicMemberBuilder builder,
            ApiAddMemberParams body,
            string namespace_,
            string topic,
            string userId
        )
        {
            AdminAddTopicMember op = builder.Build(
                body,
                namespace_,
                topic,
                userId
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminAddTopicMember(op);
        }
        public static Chat.Model.MessageActionAddUserToTopicResult? Execute(
            this AdminRemoveTopicMember.AdminRemoveTopicMemberBuilder builder,
            string namespace_,
            string topic,
            string userId
        )
        {
            AdminRemoveTopicMember op = builder.Build(
                namespace_,
                topic,
                userId
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminRemoveTopicMember(op);
        }
        public static List<Chat.Model.ModelsTopicInfo>? Execute(
            this AdminQueryTopic.AdminQueryTopicBuilder builder,
            string namespace_
        )
        {
            AdminQueryTopic op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminQueryTopic(op);
        }
        public static Chat.Model.ModelsTopicLogWithPaginationResponse? Execute(
            this AdminQueryUsersTopic.AdminQueryUsersTopicBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminQueryUsersTopic op = builder.Build(
                namespace_,
                userId
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).AdminQueryUsersTopic(op);
        }
        public static List<Chat.Model.ApiMutedTopicResponse>? Execute(
            this PublicGetMutedTopics.PublicGetMutedTopicsBuilder builder,
            string namespace_
        )
        {
            PublicGetMutedTopics op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicGetMutedTopics(op);
        }
        public static List<Chat.Model.ModelsChatMessageResponse>? Execute(
            this PublicTopicList.PublicTopicListBuilder builder,
            string namespace_
        )
        {
            PublicTopicList op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicTopicList(op);
        }
        public static Chat.Model.ModelsPublicBanTopicMembersResponse? Execute(
            this PublicBanTopicMembers.PublicBanTopicMembersBuilder builder,
            ModelsPublicBanTopicMembersRequest body,
            string namespace_,
            string topic
        )
        {
            PublicBanTopicMembers op = builder.Build(
                body,
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicBanTopicMembers(op);
        }
        public static List<Chat.Model.ModelsChatMessageResponse>? Execute(
            this PublicChatHistory.PublicChatHistoryBuilder builder,
            string namespace_,
            string topic
        )
        {
            PublicChatHistory op = builder.Build(
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicChatHistory(op);
        }
        public static void Execute(
            this PublicDeleteChat.PublicDeleteChatBuilder builder,
            string chatId,
            string namespace_,
            string topic
        )
        {
            PublicDeleteChat op = builder.Build(
                chatId,
                namespace_,
                topic
            );

            ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicDeleteChat(op);
        }
        public static void Execute(
            this PublicMuteUser.PublicMuteUserBuilder builder,
            ApiMuteUserRequest body,
            string namespace_,
            string topic
        )
        {
            PublicMuteUser op = builder.Build(
                body,
                namespace_,
                topic
            );

            ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicMuteUser(op);
        }
        public static Chat.Model.ModelsPublicUnbanTopicMembersResponse? Execute(
            this PublicUnbanTopicMembers.PublicUnbanTopicMembersBuilder builder,
            ModelsPublicUnbanTopicMembersRequest body,
            string namespace_,
            string topic
        )
        {
            PublicUnbanTopicMembers op = builder.Build(
                body,
                namespace_,
                topic
            );

            return ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicUnbanTopicMembers(op);
        }
        public static void Execute(
            this PublicUnmuteUser.PublicUnmuteUserBuilder builder,
            ApiUnmuteUserRequest body,
            string namespace_,
            string topic
        )
        {
            PublicUnmuteUser op = builder.Build(
                body,
                namespace_,
                topic
            );

            ((Chat.Wrapper.Topic)builder.WrapperObject!).PublicUnmuteUser(op);
        }
    }
}