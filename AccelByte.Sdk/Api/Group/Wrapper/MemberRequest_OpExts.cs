// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GroupMemberRequest_OpExts
    {
        public static Group.Model.ModelsGetMemberRequestsListResponseV1? Execute(
            this GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetGroupJoinRequestPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.MemberRequest)builder.WrapperObject!).GetGroupJoinRequestPublicV1(op);
        }

        public static Group.Model.ModelsGetMemberRequestsListResponseV1? Execute(
            this GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder builder,
            string namespace_
        )
        {
            GetGroupInvitationRequestPublicV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.MemberRequest)builder.WrapperObject!).GetGroupInvitationRequestPublicV1(op);
        }

    }
}