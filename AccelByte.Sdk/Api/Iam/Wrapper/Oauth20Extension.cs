using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20Extension {

        private readonly AccelByteSDK _sdk;

        public OAuth20Extension(AccelByteSDK sdk){
            _sdk = sdk;
        }

        public String UserAuthenticationV3(UserAuthenticationV3 input)  {
            HttpResponse httpResponse = _sdk.runRequest(input);

            return input.ParseResponse(
                httpResponse.Code, httpResponse.ContentType, httpResponse.Payload
            ) as string;
        }
    }
}