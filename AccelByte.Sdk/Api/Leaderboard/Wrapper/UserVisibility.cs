using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class UserVisibility {
        private readonly AccelByteSDK _sdk;

        public UserVisibility(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsGetHiddenUserResponse? GetHiddenUsersV2(GetHiddenUsersV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? GetUserVisibilityStatusV2(GetUserVisibilityStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserLeaderboardVisibilityStatusV2(SetUserLeaderboardVisibilityStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserVisibilityStatusV2(SetUserVisibilityStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}