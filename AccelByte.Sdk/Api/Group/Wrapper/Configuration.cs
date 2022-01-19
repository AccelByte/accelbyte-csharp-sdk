using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class Configuration {
        private readonly AccelByteSDK _sdk;

        public Configuration(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsListConfigurationResponseV1? ListGroupConfigurationAdminV1(ListGroupConfigurationAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupConfigurationResponseV1? CreateGroupConfigurationAdminV1(CreateGroupConfigurationAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupConfigurationResponseV1? InitiateGroupConfigurationAdminV1(InitiateGroupConfigurationAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupConfigurationResponseV1? GetGroupConfigurationAdminV1(GetGroupConfigurationAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupConfigurationV1(DeleteGroupConfigurationV1 input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateGroupConfigurationResponseV1? UpdateGroupConfigurationAdminV1(UpdateGroupConfigurationAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateGroupConfigurationResponseV1? UpdateGroupConfigurationGlobalRuleAdminV1(UpdateGroupConfigurationGlobalRuleAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateGroupConfigurationResponseV1? DeleteGroupConfigurationGlobalRuleAdminV1(DeleteGroupConfigurationGlobalRuleAdminV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}