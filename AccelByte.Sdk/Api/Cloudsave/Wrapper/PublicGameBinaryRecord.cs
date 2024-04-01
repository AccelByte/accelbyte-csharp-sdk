// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PublicGameBinaryRecord
    {
        private readonly AccelByteSDK _sdk;

        public PublicGameBinaryRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListGameBinaryRecordsV1.ListGameBinaryRecordsV1Builder ListGameBinaryRecordsV1Op
        {
            get { return Operation.ListGameBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        public PostGameBinaryRecordV1.PostGameBinaryRecordV1Builder PostGameBinaryRecordV1Op
        {
            get { return Operation.PostGameBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public BulkGetGameBinaryRecordV1.BulkGetGameBinaryRecordV1Builder BulkGetGameBinaryRecordV1Op
        {
            get { return Operation.BulkGetGameBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public GetGameBinaryRecordV1.GetGameBinaryRecordV1Builder GetGameBinaryRecordV1Op
        {
            get { return Operation.GetGameBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public PutGameBinaryRecordV1.PutGameBinaryRecordV1Builder PutGameBinaryRecordV1Op
        {
            get { return Operation.PutGameBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGameBinaryRecordV1.DeleteGameBinaryRecordV1Builder DeleteGameBinaryRecordV1Op
        {
            get { return Operation.DeleteGameBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public PostGameBinaryPresignedURLV1.PostGameBinaryPresignedURLV1Builder PostGameBinaryPresignedURLV1Op
        {
            get { return Operation.PostGameBinaryPresignedURLV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListGameBinaryRecordsResponse? ListGameBinaryRecordsV1(ListGameBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListGameBinaryRecordsResponse?> ListGameBinaryRecordsV1Async(ListGameBinaryRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? PostGameBinaryRecordV1(PostGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUploadBinaryRecordResponse?> PostGameBinaryRecordV1Async(PostGameBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkGetGameBinaryRecordResponse? BulkGetGameBinaryRecordV1(BulkGetGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetGameBinaryRecordResponse?> BulkGetGameBinaryRecordV1Async(BulkGetGameBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameBinaryRecordResponse? GetGameBinaryRecordV1(GetGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameBinaryRecordResponse?> GetGameBinaryRecordV1Async(GetGameBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameBinaryRecordResponse? PutGameBinaryRecordV1(PutGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameBinaryRecordResponse?> PutGameBinaryRecordV1Async(PutGameBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGameBinaryRecordV1(DeleteGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGameBinaryRecordV1Async(DeleteGameBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? PostGameBinaryPresignedURLV1(PostGameBinaryPresignedURLV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUploadBinaryRecordResponse?> PostGameBinaryPresignedURLV1Async(PostGameBinaryPresignedURLV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}