using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class MemberRequest {
        private readonly AccelByteSDK _sdk;

        public MemberRequest(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupJoinRequestPublicV1(GetGroupJoinRequestPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}