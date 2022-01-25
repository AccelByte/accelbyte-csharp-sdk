using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicTag {
        private readonly AccelByteSDK _sdk;

        public PublicTag(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsPaginatedGetTagResponse? GetTag(GetTag input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}