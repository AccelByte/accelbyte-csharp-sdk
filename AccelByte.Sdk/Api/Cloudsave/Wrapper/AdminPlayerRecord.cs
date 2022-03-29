// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminPlayerRecord {
        private readonly AccelByteSDK _sdk;

        public AdminPlayerRecord(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsListPlayerRecordKeysResponse? ListPlayerRecordHandlerV1(ListPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsListPlayerRecordKeysResponse? AdminRetrievePlayerRecords(AdminRetrievePlayerRecords input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminGetPlayerRecordHandlerV1(AdminGetPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerRecordHandlerV1(AdminPutPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPostPlayerRecordHandlerV1(AdminPostPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerRecordHandlerV1(AdminDeletePlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminGetPlayerPublicRecordHandlerV1(AdminGetPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerPublicRecordHandlerV1(AdminPutPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPostPlayerPublicRecordHandlerV1(AdminPostPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerPublicRecordHandlerV1(AdminDeletePlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}