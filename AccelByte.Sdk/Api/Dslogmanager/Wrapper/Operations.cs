using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class Operations {
        private readonly AccelByteSDK _sdk;

        public Operations(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}