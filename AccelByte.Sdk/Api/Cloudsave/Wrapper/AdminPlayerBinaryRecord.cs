// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminPlayerBinaryRecord
    {
        private readonly AccelByteSDK _sdk;

        public AdminPlayerBinaryRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListPlayerBinaryRecordsV1.AdminListPlayerBinaryRecordsV1Builder AdminListPlayerBinaryRecordsV1Op
        {
            get { return Operation.AdminListPlayerBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostPlayerBinaryRecordV1.AdminPostPlayerBinaryRecordV1Builder AdminPostPlayerBinaryRecordV1Op
        {
            get { return Operation.AdminPostPlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerBinaryRecordV1.AdminGetPlayerBinaryRecordV1Builder AdminGetPlayerBinaryRecordV1Op
        {
            get { return Operation.AdminGetPlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerBinaryRecordV1.AdminPutPlayerBinaryRecordV1Builder AdminPutPlayerBinaryRecordV1Op
        {
            get { return Operation.AdminPutPlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlayerBinaryRecordV1.AdminDeletePlayerBinaryRecordV1Builder AdminDeletePlayerBinaryRecordV1Op
        {
            get { return Operation.AdminDeletePlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerBinaryRecorMetadataV1.AdminPutPlayerBinaryRecorMetadataV1Builder AdminPutPlayerBinaryRecorMetadataV1Op
        {
            get { return Operation.AdminPutPlayerBinaryRecorMetadataV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostPlayerBinaryPresignedURLV1.AdminPostPlayerBinaryPresignedURLV1Builder AdminPostPlayerBinaryPresignedURLV1Op
        {
            get { return Operation.AdminPostPlayerBinaryPresignedURLV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListPlayerBinaryRecordsResponse? AdminListPlayerBinaryRecordsV1(AdminListPlayerBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? AdminPostPlayerBinaryRecordV1(AdminPostPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? AdminGetPlayerBinaryRecordV1(AdminGetPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? AdminPutPlayerBinaryRecordV1(AdminPutPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerBinaryRecordV1(AdminDeletePlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? AdminPutPlayerBinaryRecorMetadataV1(AdminPutPlayerBinaryRecorMetadataV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? AdminPostPlayerBinaryPresignedURLV1(AdminPostPlayerBinaryPresignedURLV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}