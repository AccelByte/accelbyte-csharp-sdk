// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Topic
    {
        private readonly AccelByteSDK _sdk;

        public Topic(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminChatHistory.AdminChatHistoryBuilder AdminChatHistoryOp
        {
            get { return Operation.AdminChatHistory.Builder.SetWrapperObject(this); }
        }
        public AdminCreateNamespaceTopic.AdminCreateNamespaceTopicBuilder AdminCreateNamespaceTopicOp
        {
            get { return Operation.AdminCreateNamespaceTopic.Builder.SetWrapperObject(this); }
        }
        public AdminTopicList.AdminTopicListBuilder AdminTopicListOp
        {
            get { return Operation.AdminTopicList.Builder.SetWrapperObject(this); }
        }
        public AdminCreateTopic.AdminCreateTopicBuilder AdminCreateTopicOp
        {
            get { return Operation.AdminCreateTopic.Builder.SetWrapperObject(this); }
        }
        public AdminChannelTopicList.AdminChannelTopicListBuilder AdminChannelTopicListOp
        {
            get { return Operation.AdminChannelTopicList.Builder.SetWrapperObject(this); }
        }
        public AdminChannelTopicSummary.AdminChannelTopicSummaryBuilder AdminChannelTopicSummaryOp
        {
            get { return Operation.AdminChannelTopicSummary.Builder.SetWrapperObject(this); }
        }
        public AdminQueryTopicLog.AdminQueryTopicLogBuilder AdminQueryTopicLogOp
        {
            get { return Operation.AdminQueryTopicLog.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateTopic.AdminUpdateTopicBuilder AdminUpdateTopicOp
        {
            get { return Operation.AdminUpdateTopic.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteTopic.AdminDeleteTopicBuilder AdminDeleteTopicOp
        {
            get { return Operation.AdminDeleteTopic.Builder.SetWrapperObject(this); }
        }
        public AdminBanTopicMembers.AdminBanTopicMembersBuilder AdminBanTopicMembersOp
        {
            get { return Operation.AdminBanTopicMembers.Builder.SetWrapperObject(this); }
        }
        public AdminChannelTopicInfo.AdminChannelTopicInfoBuilder AdminChannelTopicInfoOp
        {
            get { return Operation.AdminChannelTopicInfo.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminTopicChatHistory.AdminTopicChatHistoryBuilder AdminTopicChatHistoryOp
        {
            get { return Operation.AdminTopicChatHistory.Builder.SetWrapperObject(this); }
        }
        public AdminSendChat.AdminSendChatBuilder AdminSendChatOp
        {
            get { return Operation.AdminSendChat.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteChat.AdminDeleteChatBuilder AdminDeleteChatOp
        {
            get { return Operation.AdminDeleteChat.Builder.SetWrapperObject(this); }
        }
        public AdminTopicMembers.AdminTopicMembersBuilder AdminTopicMembersOp
        {
            get { return Operation.AdminTopicMembers.Builder.SetWrapperObject(this); }
        }
        public AdminTopicShards.AdminTopicShardsBuilder AdminTopicShardsOp
        {
            get { return Operation.AdminTopicShards.Builder.SetWrapperObject(this); }
        }
        public AdminUnbanTopicMembers.AdminUnbanTopicMembersBuilder AdminUnbanTopicMembersOp
        {
            get { return Operation.AdminUnbanTopicMembers.Builder.SetWrapperObject(this); }
        }
        public AdminAddTopicMember.AdminAddTopicMemberBuilder AdminAddTopicMemberOp
        {
            get { return Operation.AdminAddTopicMember.Builder.SetWrapperObject(this); }
        }
        public AdminRemoveTopicMember.AdminRemoveTopicMemberBuilder AdminRemoveTopicMemberOp
        {
            get { return Operation.AdminRemoveTopicMember.Builder.SetWrapperObject(this); }
        }
        public AdminQueryTopic.AdminQueryTopicBuilder AdminQueryTopicOp
        {
            get { return Operation.AdminQueryTopic.Builder.SetWrapperObject(this); }
        }
        public AdminQueryUsersTopic.AdminQueryUsersTopicBuilder AdminQueryUsersTopicOp
        {
            get { return Operation.AdminQueryUsersTopic.Builder.SetWrapperObject(this); }
        }
        public PublicGetMutedTopics.PublicGetMutedTopicsBuilder PublicGetMutedTopicsOp
        {
            get { return Operation.PublicGetMutedTopics.Builder.SetWrapperObject(this); }
        }
        public PublicTopicList.PublicTopicListBuilder PublicTopicListOp
        {
            get { return Operation.PublicTopicList.Builder.SetWrapperObject(this); }
        }
        public PublicBanTopicMembers.PublicBanTopicMembersBuilder PublicBanTopicMembersOp
        {
            get { return Operation.PublicBanTopicMembers.Builder.SetWrapperObject(this); }
        }
        public PublicChatHistory.PublicChatHistoryBuilder PublicChatHistoryOp
        {
            get { return Operation.PublicChatHistory.Builder.SetWrapperObject(this); }
        }
        public PublicDeleteChat.PublicDeleteChatBuilder PublicDeleteChatOp
        {
            get { return Operation.PublicDeleteChat.Builder.SetWrapperObject(this); }
        }
        public PublicMuteUser.PublicMuteUserBuilder PublicMuteUserOp
        {
            get { return Operation.PublicMuteUser.Builder.SetWrapperObject(this); }
        }
        public PublicUnbanTopicMembers.PublicUnbanTopicMembersBuilder PublicUnbanTopicMembersOp
        {
            get { return Operation.PublicUnbanTopicMembers.Builder.SetWrapperObject(this); }
        }
        public PublicUnmuteUser.PublicUnmuteUserBuilder PublicUnmuteUserOp
        {
            get { return Operation.PublicUnmuteUser.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsChatMessageWithPaginationResponse? AdminChatHistory(AdminChatHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiCreateTopicResponse? AdminCreateNamespaceTopic(AdminCreateNamespaceTopic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsTopicResponse>? AdminTopicList(AdminTopicList input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiCreateTopicResponse? AdminCreateTopic(AdminCreateTopic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelTopicWithPaginationResponse? AdminChannelTopicList(AdminChannelTopicList input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelTopicSummaryResponse? AdminChannelTopicSummary(AdminChannelTopicSummary input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsTopicLogWithPaginationResponse? AdminQueryTopicLog(AdminQueryTopicLog input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiCreateTopicResponse? AdminUpdateTopic(AdminUpdateTopic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.MessageActionDeleteTopicResult? AdminDeleteTopic(AdminDeleteTopic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBanTopicMemberResult? AdminBanTopicMembers(AdminBanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelTopicResponse? AdminChannelTopicInfo(AdminChannelTopicInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsChatMessageWithPaginationResponse? AdminTopicChatHistory(AdminTopicChatHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public List<Model.ModelsChatMessageResponse>? AdminSendChat(AdminSendChat input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteChat(AdminDeleteChat input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsTopicMemberWithPaginationResponse? AdminTopicMembers(AdminTopicMembers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? AdminTopicShards(AdminTopicShards input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUnbanTopicMemberResult? AdminUnbanTopicMembers(AdminUnbanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.MessageActionAddUserToTopicResult? AdminAddTopicMember(AdminAddTopicMember input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.MessageActionAddUserToTopicResult? AdminRemoveTopicMember(AdminRemoveTopicMember input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsTopicInfo>? AdminQueryTopic(AdminQueryTopic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsTopicLogWithPaginationResponse? AdminQueryUsersTopic(AdminQueryUsersTopic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApiMutedTopicResponse>? PublicGetMutedTopics(PublicGetMutedTopics input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChatMessageResponse>? PublicTopicList(PublicTopicList input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPublicBanTopicMembersResponse? PublicBanTopicMembers(PublicBanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChatMessageResponse>? PublicChatHistory(PublicChatHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeleteChat(PublicDeleteChat input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicMuteUser(PublicMuteUser input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPublicUnbanTopicMembersResponse? PublicUnbanTopicMembers(PublicUnbanTopicMembers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUnmuteUser(PublicUnmuteUser input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}