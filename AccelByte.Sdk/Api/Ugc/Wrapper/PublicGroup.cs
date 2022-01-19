using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicGroup {
        private readonly AccelByteSDK _sdk;

        public PublicGroup(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsPaginatedGroupResponse? GetGroups(GetGroups input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? CreateGroup(CreateGroup input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? GetGroup(GetGroup input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? UpdateGroup(UpdateGroup input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroup(DeleteGroup input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? GetGroupContent(GetGroupContent input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}