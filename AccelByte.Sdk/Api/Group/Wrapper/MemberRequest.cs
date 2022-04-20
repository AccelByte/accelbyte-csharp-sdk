// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class MemberRequest
    {
        private readonly AccelByteSDK _sdk;

        public MemberRequest(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder GetGroupJoinRequestPublicV1Op
        {
            get { return Operation.GetGroupJoinRequestPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder GetGroupInvitationRequestPublicV1Op
        {
            get { return Operation.GetGroupInvitationRequestPublicV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupJoinRequestPublicV1(GetGroupJoinRequestPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class MemberRequest_OperationExtensions
    {
        public static Model.ModelsGetMemberRequestsListResponseV1? Execute(
            this GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetGroupJoinRequestPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((MemberRequest)builder.WrapperObject!).GetGroupJoinRequestPublicV1(op);
        }

        public static Model.ModelsGetMemberRequestsListResponseV1? Execute(
            this GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder builder,
            string namespace_
        )
        {
            GetGroupInvitationRequestPublicV1 op = builder.Build(
                namespace_
            );

            return ((MemberRequest)builder.WrapperObject!).GetGroupInvitationRequestPublicV1(op);
        }

    }
}