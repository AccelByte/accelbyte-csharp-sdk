using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class InputValidations {
        private readonly AccelByteSDK _sdk;

        public InputValidations(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelInputValidationsResponse? AdminGetInputValidations(AdminGetInputValidations input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateInputValidations(AdminUpdateInputValidations input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetInputValidations(AdminResetInputValidations input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInputValidationsPublicResponse? PublicGetInputValidations(PublicGetInputValidations input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}