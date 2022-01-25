using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicLike {
        private readonly AccelByteSDK _sdk;

        public PublicLike(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsPaginatedContentDownloadResponse? GetLikedContent(GetLikedContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentLikeResponse? UpdateContentLikeStatus(UpdateContentLikeStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}