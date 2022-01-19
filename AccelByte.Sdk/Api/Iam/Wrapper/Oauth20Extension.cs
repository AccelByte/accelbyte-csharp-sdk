using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20Extension {
        private readonly AccelByteSDK _sdk;

        public OAuth20Extension(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public string UserAuthenticationV3(UserAuthenticationV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelCountryLocationResponse? GetCountryLocationV3(GetCountryLocationV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void Logout(Logout input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string PlatformAuthenticationV3(PlatformAuthenticationV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}