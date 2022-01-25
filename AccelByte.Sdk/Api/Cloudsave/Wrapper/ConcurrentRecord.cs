using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class ConcurrentRecord {
        private readonly AccelByteSDK _sdk;

        public ConcurrentRecord(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public void PutGameRecordConcurrentHandlerV1(PutGameRecordConcurrentHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PutPlayerPublicRecordConcurrentHandlerV1(PutPlayerPublicRecordConcurrentHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}