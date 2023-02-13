// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public GetGroupInviteRequestPublicV2.GetGroupInviteRequestPublicV2Builder GetGroupInviteRequestPublicV2Op
        {
            get { return Operation.GetGroupInviteRequestPublicV2.Builder.SetWrapperObject(this); }
        }
        public GetGroupJoinRequestPublicV2.GetGroupJoinRequestPublicV2Builder GetGroupJoinRequestPublicV2Op
        {
            get { return Operation.GetGroupJoinRequestPublicV2.Builder.SetWrapperObject(this); }
        }
        public GetMyGroupJoinRequestV2.GetMyGroupJoinRequestV2Builder GetMyGroupJoinRequestV2Op
        {
            get { return Operation.GetMyGroupJoinRequestV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupJoinRequestPublicV1(GetGroupJoinRequestPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupInviteRequestPublicV2(GetGroupInviteRequestPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupJoinRequestPublicV2(GetGroupJoinRequestPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetMyGroupJoinRequestV2(GetMyGroupJoinRequestV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}