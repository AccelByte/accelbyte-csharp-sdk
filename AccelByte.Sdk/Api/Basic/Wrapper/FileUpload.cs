using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class FileUpload {
        private readonly AccelByteSDK _sdk;

        public FileUpload(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.FileUploadUrlInfo? GeneratedUploadUrl(GeneratedUploadUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? GeneratedUserUploadContentUrl(GeneratedUserUploadContentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? PublicGeneratedUploadUrl(PublicGeneratedUploadUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? PublicGeneratedUserUploadContentUrl(PublicGeneratedUserUploadContentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}