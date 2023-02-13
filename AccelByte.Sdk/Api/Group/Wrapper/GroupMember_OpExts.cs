// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GroupGroupMember_OpExts
    {
        public static Group.Model.ModelsGetGroupMemberListResponseV1? Execute(
            this GetGroupMembersListAdminV1.GetGroupMembersListAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetGroupMembersListAdminV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).GetGroupMembersListAdminV1(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this AcceptGroupInvitationPublicV1.AcceptGroupInvitationPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            AcceptGroupInvitationPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).AcceptGroupInvitationPublicV1(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this RejectGroupInvitationPublicV1.RejectGroupInvitationPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            RejectGroupInvitationPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).RejectGroupInvitationPublicV1(op);
        }
        public static Group.Model.ModelsJoinGroupResponseV1? Execute(
            this JoinGroupV1.JoinGroupV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            JoinGroupV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).JoinGroupV1(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this CancelGroupJoinRequestV1.CancelGroupJoinRequestV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            CancelGroupJoinRequestV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).CancelGroupJoinRequestV1(op);
        }
        public static Group.Model.ModelsGetGroupMemberListResponseV1? Execute(
            this GetGroupMembersListPublicV1.GetGroupMembersListPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetGroupMembersListPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).GetGroupMembersListPublicV1(op);
        }
        public static Group.Model.ModelsLeaveGroupResponseV1? Execute(
            this LeaveGroupPublicV1.LeaveGroupPublicV1Builder builder,
            string namespace_
        )
        {
            LeaveGroupPublicV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).LeaveGroupPublicV1(op);
        }
        public static Group.Model.ModelsGetUserGroupInformationResponseV1? Execute(
            this GetUserGroupInformationPublicV1.GetUserGroupInformationPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            GetUserGroupInformationPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).GetUserGroupInformationPublicV1(op);
        }
        public static Group.Model.ModelsUserInvitationResponseV1? Execute(
            this InviteGroupPublicV1.InviteGroupPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            InviteGroupPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).InviteGroupPublicV1(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this AcceptGroupJoinRequestPublicV1.AcceptGroupJoinRequestPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AcceptGroupJoinRequestPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).AcceptGroupJoinRequestPublicV1(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this RejectGroupJoinRequestPublicV1.RejectGroupJoinRequestPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            RejectGroupJoinRequestPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).RejectGroupJoinRequestPublicV1(op);
        }
        public static Group.Model.ModelsKickGroupMemberResponseV1? Execute(
            this KickGroupMemberPublicV1.KickGroupMemberPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            KickGroupMemberPublicV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).KickGroupMemberPublicV1(op);
        }
        public static Group.Model.ModelsGetGroupMemberListResponseV1? Execute(
            this GetUserJoinedGroupInformationPublicV2.GetUserJoinedGroupInformationPublicV2Builder builder,
            string namespace_,
            string userId
        )
        {
            GetUserJoinedGroupInformationPublicV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).GetUserJoinedGroupInformationPublicV2(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this AcceptGroupInvitationPublicV2.AcceptGroupInvitationPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            AcceptGroupInvitationPublicV2 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).AcceptGroupInvitationPublicV2(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this RejectGroupInvitationPublicV2.RejectGroupInvitationPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            RejectGroupInvitationPublicV2 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).RejectGroupInvitationPublicV2(op);
        }
        public static Group.Model.ModelsJoinGroupResponseV1? Execute(
            this JoinGroupV2.JoinGroupV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            JoinGroupV2 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).JoinGroupV2(op);
        }
        public static Group.Model.ModelsLeaveGroupResponseV1? Execute(
            this LeaveGroupPublicV2.LeaveGroupPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            LeaveGroupPublicV2 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).LeaveGroupPublicV2(op);
        }
        public static Group.Model.ModelsGetGroupMemberListResponseV1? Execute(
            this GetUserGroupInformationPublicV2.GetUserGroupInformationPublicV2Builder builder,
            string namespace_
        )
        {
            GetUserGroupInformationPublicV2 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).GetUserGroupInformationPublicV2(op);
        }
        public static Group.Model.ModelsUserInvitationResponseV1? Execute(
            this InviteGroupPublicV2.InviteGroupPublicV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            InviteGroupPublicV2 op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).InviteGroupPublicV2(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this AcceptGroupJoinRequestPublicV2.AcceptGroupJoinRequestPublicV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AcceptGroupJoinRequestPublicV2 op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).AcceptGroupJoinRequestPublicV2(op);
        }
        public static Group.Model.ModelsMemberRequestGroupResponseV1? Execute(
            this RejectGroupJoinRequestPublicV2.RejectGroupJoinRequestPublicV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            RejectGroupJoinRequestPublicV2 op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).RejectGroupJoinRequestPublicV2(op);
        }
        public static Group.Model.ModelsKickGroupMemberResponseV1? Execute(
            this KickGroupMemberPublicV2.KickGroupMemberPublicV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            KickGroupMemberPublicV2 op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).KickGroupMemberPublicV2(op);
        }
        public static Group.Model.ModelsGetUserGroupInformationResponseV1? Execute(
            this GetUserGroupStatusInformationV2.GetUserGroupStatusInformationV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            GetUserGroupStatusInformationV2 op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Group.Wrapper.GroupMember)builder.WrapperObject!).GetUserGroupStatusInformationV2(op);
        }
    }
}