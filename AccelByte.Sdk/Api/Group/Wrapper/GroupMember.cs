using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class GroupMember {
        private readonly AccelByteSDK _sdk;

        public GroupMember(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsGetGroupMemberListResponseV1? GetGroupMembersListAdminV1(GetGroupMembersListAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? AcceptGroupInvitationPublicV1(AcceptGroupInvitationPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? RejectGroupInvitationPublicV1(RejectGroupInvitationPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsJoinGroupResponseV1? JoinGroupV1(JoinGroupV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? CancelGroupJoinRequestV1(CancelGroupJoinRequestV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupMemberListResponseV1? GetGroupMembersListPublicV1(GetGroupMembersListPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLeaveGroupResponseV1? LeaveGroupPublicV1(LeaveGroupPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserGroupInformationResponseV1? GetUserGroupInformationPublicV1(GetUserGroupInformationPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserInvitationResponseV1? InviteGroupPublicV1(InviteGroupPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? AcceptGroupJoinRequestPublicV1(AcceptGroupJoinRequestPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRequestGroupResponseV1? RejectGroupJoinRequestPublicV1(RejectGroupJoinRequestPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsKickGroupMemberResponseV1? KickGroupMemberPublicV1(KickGroupMemberPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}