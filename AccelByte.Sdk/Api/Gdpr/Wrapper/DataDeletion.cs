using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class DataDeletion {
        private readonly AccelByteSDK _sdk;

        public DataDeletion(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsListDeletionDataResponse? AdminGetListDeletionDataRequest(AdminGetListDeletionDataRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionData? AdminGetUserAccountDeletionRequest(AdminGetUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? AdminSubmitUserAccountDeletionRequest(AdminSubmitUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCancelUserAccountDeletionRequest(AdminCancelUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? PublicSubmitUserAccountDeletionRequest(PublicSubmitUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCancelUserAccountDeletionRequest(PublicCancelUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionStatus? PublicGetUserAccountDeletionStatus(PublicGetUserAccountDeletionStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}