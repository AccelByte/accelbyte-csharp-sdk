using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class SSOSAML20 {
        private readonly AccelByteSDK _sdk;

        public SSOSAML20(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public string PlatformAuthenticateSAMLV3Handler(PlatformAuthenticateSAMLV3Handler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}