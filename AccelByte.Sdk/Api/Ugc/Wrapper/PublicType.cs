using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicType {
        private readonly AccelByteSDK _sdk;

        public PublicType(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsPaginatedGetTypeResponse? GetType(GetType input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}