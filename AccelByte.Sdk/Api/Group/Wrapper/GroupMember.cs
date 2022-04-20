// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class GroupMember
    {
        private readonly AccelByteSDK _sdk;

        public GroupMember(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGroupMembersListAdminV1.GetGroupMembersListAdminV1Builder GetGroupMembersListAdminV1Op
        {
            get { return Operation.GetGroupMembersListAdminV1.Builder.SetWrapperObject(this); }
        }
        public AcceptGroupInvitationPublicV1.AcceptGroupInvitationPublicV1Builder AcceptGroupInvitationPublicV1Op
        {
            get { return Operation.AcceptGroupInvitationPublicV1.Builder.SetWrapperObject(this); }
        }
        public RejectGroupInvitationPublicV1.RejectGroupInvitationPublicV1Builder RejectGroupInvitationPublicV1Op
        {
            get { return Operation.RejectGroupInvitationPublicV1.Builder.SetWrapperObject(this); }
        }
        public JoinGroupV1.JoinGroupV1Builder JoinGroupV1Op
        {
            get { return Operation.JoinGroupV1.Builder.SetWrapperObject(this); }
        }
        public CancelGroupJoinRequestV1.CancelGroupJoinRequestV1Builder CancelGroupJoinRequestV1Op
        {
            get { return Operation.CancelGroupJoinRequestV1.Builder.SetWrapperObject(this); }
        }
        public GetGroupMembersListPublicV1.GetGroupMembersListPublicV1Builder GetGroupMembersListPublicV1Op
        {
            get { return Operation.GetGroupMembersListPublicV1.Builder.SetWrapperObject(this); }
        }
        public LeaveGroupPublicV1.LeaveGroupPublicV1Builder LeaveGroupPublicV1Op
        {
            get { return Operation.LeaveGroupPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetUserGroupInformationPublicV1.GetUserGroupInformationPublicV1Builder GetUserGroupInformationPublicV1Op
        {
            get { return Operation.GetUserGroupInformationPublicV1.Builder.SetWrapperObject(this); }
        }
        public InviteGroupPublicV1.InviteGroupPublicV1Builder InviteGroupPublicV1Op
        {
            get { return Operation.InviteGroupPublicV1.Builder.SetWrapperObject(this); }
        }
        public AcceptGroupJoinRequestPublicV1.AcceptGroupJoinRequestPublicV1Builder AcceptGroupJoinRequestPublicV1Op
        {
            get { return Operation.AcceptGroupJoinRequestPublicV1.Builder.SetWrapperObject(this); }
        }
        public RejectGroupJoinRequestPublicV1.RejectGroupJoinRequestPublicV1Builder RejectGroupJoinRequestPublicV1Op
        {
            get { return Operation.RejectGroupJoinRequestPublicV1.Builder.SetWrapperObject(this); }
        }
        public KickGroupMemberPublicV1.KickGroupMemberPublicV1Builder KickGroupMemberPublicV1Op
        {
            get { return Operation.KickGroupMemberPublicV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetGroupMemberListResponseV1? GetGroupMembersListAdminV1(GetGroupMembersListAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? AcceptGroupInvitationPublicV1(AcceptGroupInvitationPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? RejectGroupInvitationPublicV1(RejectGroupInvitationPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsJoinGroupResponseV1? JoinGroupV1(JoinGroupV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? CancelGroupJoinRequestV1(CancelGroupJoinRequestV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupMemberListResponseV1? GetGroupMembersListPublicV1(GetGroupMembersListPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLeaveGroupResponseV1? LeaveGroupPublicV1(LeaveGroupPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserGroupInformationResponseV1? GetUserGroupInformationPublicV1(GetUserGroupInformationPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserInvitationResponseV1? InviteGroupPublicV1(InviteGroupPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? AcceptGroupJoinRequestPublicV1(AcceptGroupJoinRequestPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? RejectGroupJoinRequestPublicV1(RejectGroupJoinRequestPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsKickGroupMemberResponseV1? KickGroupMemberPublicV1(KickGroupMemberPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class GroupMember_OperationExtensions
    {
        public static Model.ModelsGetGroupMemberListResponseV1? Execute(
            this GetGroupMembersListAdminV1.GetGroupMembersListAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetGroupMembersListAdminV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).GetGroupMembersListAdminV1(op);
        }

        public static Model.ModelsMemberRequestGroupResponseV1? Execute(
            this AcceptGroupInvitationPublicV1.AcceptGroupInvitationPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            AcceptGroupInvitationPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).AcceptGroupInvitationPublicV1(op);
        }

        public static Model.ModelsMemberRequestGroupResponseV1? Execute(
            this RejectGroupInvitationPublicV1.RejectGroupInvitationPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            RejectGroupInvitationPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).RejectGroupInvitationPublicV1(op);
        }

        public static Model.ModelsJoinGroupResponseV1? Execute(
            this JoinGroupV1.JoinGroupV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            JoinGroupV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).JoinGroupV1(op);
        }

        public static Model.ModelsMemberRequestGroupResponseV1? Execute(
            this CancelGroupJoinRequestV1.CancelGroupJoinRequestV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            CancelGroupJoinRequestV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).CancelGroupJoinRequestV1(op);
        }

        public static Model.ModelsGetGroupMemberListResponseV1? Execute(
            this GetGroupMembersListPublicV1.GetGroupMembersListPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetGroupMembersListPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).GetGroupMembersListPublicV1(op);
        }

        public static Model.ModelsLeaveGroupResponseV1? Execute(
            this LeaveGroupPublicV1.LeaveGroupPublicV1Builder builder,
            string namespace_
        )
        {
            LeaveGroupPublicV1 op = builder.Build(
                namespace_
            );

            return ((GroupMember)builder.WrapperObject!).LeaveGroupPublicV1(op);
        }

        public static Model.ModelsGetUserGroupInformationResponseV1? Execute(
            this GetUserGroupInformationPublicV1.GetUserGroupInformationPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            GetUserGroupInformationPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((GroupMember)builder.WrapperObject!).GetUserGroupInformationPublicV1(op);
        }

        public static Model.ModelsUserInvitationResponseV1? Execute(
            this InviteGroupPublicV1.InviteGroupPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            InviteGroupPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((GroupMember)builder.WrapperObject!).InviteGroupPublicV1(op);
        }

        public static Model.ModelsMemberRequestGroupResponseV1? Execute(
            this AcceptGroupJoinRequestPublicV1.AcceptGroupJoinRequestPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AcceptGroupJoinRequestPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((GroupMember)builder.WrapperObject!).AcceptGroupJoinRequestPublicV1(op);
        }

        public static Model.ModelsMemberRequestGroupResponseV1? Execute(
            this RejectGroupJoinRequestPublicV1.RejectGroupJoinRequestPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            RejectGroupJoinRequestPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((GroupMember)builder.WrapperObject!).RejectGroupJoinRequestPublicV1(op);
        }

        public static Model.ModelsKickGroupMemberResponseV1? Execute(
            this KickGroupMemberPublicV1.KickGroupMemberPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            KickGroupMemberPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((GroupMember)builder.WrapperObject!).KickGroupMemberPublicV1(op);
        }

    }
}