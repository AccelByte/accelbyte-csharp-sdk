using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class LeaderboardConfiguration {
        private readonly AccelByteSDK _sdk;

        public LeaderboardConfiguration(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsGetAllLeaderboardConfigsResp? GetLeaderboardConfigurationsAdminV1(GetLeaderboardConfigurationsAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLeaderboardConfigReq? CreateLeaderboardConfigurationAdminV1(CreateLeaderboardConfigurationAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeleteBulkLeaderboardsResp? DeleteBulkLeaderboardConfigurationAdminV1(DeleteBulkLeaderboardConfigurationAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardConfigResp? GetLeaderboardConfigurationAdminV1(GetLeaderboardConfigurationAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardConfigResp? UpdateLeaderboardConfigurationAdminV1(UpdateLeaderboardConfigurationAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLeaderboardConfigurationAdminV1(DeleteLeaderboardConfigurationAdminV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllLeaderboardConfigsPublicResp? GetLeaderboardConfigurationsPublicV1(GetLeaderboardConfigurationsPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLeaderboardConfigReq? CreateLeaderboardConfigurationPublicV1(CreateLeaderboardConfigurationPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.V2GetAllLeaderboardConfigsPublicResp? GetLeaderboardConfigurationsPublicV2(GetLeaderboardConfigurationsPublicV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}