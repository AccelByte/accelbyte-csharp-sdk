using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20 {
        private readonly AccelByteSDK _sdk;

        public OAuth20(AccelByteSDK sdk){
            _sdk = sdk;
        }

        // TODO More

        public OauthmodelTokenResponseV3 TokenGrantV3(TokenGrantV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload) as OauthmodelTokenResponseV3;
        }

        public string AuthorizeV3(AuthorizeV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload) as string;
        }
    }
}