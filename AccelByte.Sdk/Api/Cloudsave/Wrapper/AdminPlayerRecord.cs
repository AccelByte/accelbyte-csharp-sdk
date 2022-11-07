// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminPlayerRecord
    {
        private readonly AccelByteSDK _sdk;

        public AdminPlayerRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public BulkGetPlayerRecordSizeHandlerV1.BulkGetPlayerRecordSizeHandlerV1Builder BulkGetPlayerRecordSizeHandlerV1Op
        {
            get { return Operation.BulkGetPlayerRecordSizeHandlerV1.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder ListPlayerRecordHandlerV1Op
        {
            get { return Operation.ListPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder AdminRetrievePlayerRecordsOp
        {
            get { return Operation.AdminRetrievePlayerRecords.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder AdminGetPlayerRecordHandlerV1Op
        {
            get { return Operation.AdminGetPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder AdminPutPlayerRecordHandlerV1Op
        {
            get { return Operation.AdminPutPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder AdminPostPlayerRecordHandlerV1Op
        {
            get { return Operation.AdminPostPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder AdminDeletePlayerRecordHandlerV1Op
        {
            get { return Operation.AdminDeletePlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder AdminGetPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminGetPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder AdminPutPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminPutPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder AdminPostPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminPostPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder AdminDeletePlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminDeletePlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerRecordSizeHandlerV1.AdminGetPlayerRecordSizeHandlerV1Builder AdminGetPlayerRecordSizeHandlerV1Op
        {
            get { return Operation.AdminGetPlayerRecordSizeHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsBulkGetPlayerRecordSizeResponse? BulkGetPlayerRecordSizeHandlerV1(BulkGetPlayerRecordSizeHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
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
        public Model.ModelsPlayerRecordResponse? AdminPutPlayerRecordHandlerV1(AdminPutPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminPostPlayerRecordHandlerV1(AdminPostPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
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
        public Model.ModelsPlayerRecordResponse? AdminPutPlayerPublicRecordHandlerV1(AdminPutPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminPostPlayerPublicRecordHandlerV1(AdminPostPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
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
        public Model.ModelsPlayerRecordSizeResponse? AdminGetPlayerRecordSizeHandlerV1(AdminGetPlayerRecordSizeHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}