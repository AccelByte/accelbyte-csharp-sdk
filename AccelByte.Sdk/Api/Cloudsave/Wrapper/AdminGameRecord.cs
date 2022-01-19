using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminGameRecord {
        private readonly AccelByteSDK _sdk;

        public AdminGameRecord(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsListGameRecordKeys? ListGameRecordsHandlerV1(ListGameRecordsHandlerV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecord? AdminGetGameRecordHandlerV1(AdminGetGameRecordHandlerV1 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutGameRecordHandlerV1(AdminPutGameRecordHandlerV1 input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPostGameRecordHandlerV1(AdminPostGameRecordHandlerV1 input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGameRecordHandlerV1(AdminDeleteGameRecordHandlerV1 input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}