// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PublicPlayerBinaryRecord
    {
        private readonly AccelByteSDK _sdk;

        public PublicPlayerBinaryRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public BulkGetPlayerPublicBinaryRecordsV1.BulkGetPlayerPublicBinaryRecordsV1Builder BulkGetPlayerPublicBinaryRecordsV1Op
        {
            get { return Operation.BulkGetPlayerPublicBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        public ListMyBinaryRecordsV1.ListMyBinaryRecordsV1Builder ListMyBinaryRecordsV1Op
        {
            get { return Operation.ListMyBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        public BulkGetMyBinaryRecordV1.BulkGetMyBinaryRecordV1Builder BulkGetMyBinaryRecordV1Op
        {
            get { return Operation.BulkGetMyBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public PostPlayerBinaryRecordV1.PostPlayerBinaryRecordV1Builder PostPlayerBinaryRecordV1Op
        {
            get { return Operation.PostPlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public ListOtherPlayerPublicBinaryRecordsV1.ListOtherPlayerPublicBinaryRecordsV1Builder ListOtherPlayerPublicBinaryRecordsV1Op
        {
            get { return Operation.ListOtherPlayerPublicBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        public BulkGetOtherPlayerPublicBinaryRecordsV1.BulkGetOtherPlayerPublicBinaryRecordsV1Builder BulkGetOtherPlayerPublicBinaryRecordsV1Op
        {
            get { return Operation.BulkGetOtherPlayerPublicBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        public GetPlayerBinaryRecordV1.GetPlayerBinaryRecordV1Builder GetPlayerBinaryRecordV1Op
        {
            get { return Operation.GetPlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public PutPlayerBinaryRecordV1.PutPlayerBinaryRecordV1Builder PutPlayerBinaryRecordV1Op
        {
            get { return Operation.PutPlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public DeletePlayerBinaryRecordV1.DeletePlayerBinaryRecordV1Builder DeletePlayerBinaryRecordV1Op
        {
            get { return Operation.DeletePlayerBinaryRecordV1.Builder.SetWrapperObject(this); }
        }
        public PutPlayerBinaryRecorMetadataV1.PutPlayerBinaryRecorMetadataV1Builder PutPlayerBinaryRecorMetadataV1Op
        {
            get { return Operation.PutPlayerBinaryRecorMetadataV1.Builder.SetWrapperObject(this); }
        }
        public PostPlayerBinaryPresignedURLV1.PostPlayerBinaryPresignedURLV1Builder PostPlayerBinaryPresignedURLV1Op
        {
            get { return Operation.PostPlayerBinaryPresignedURLV1.Builder.SetWrapperObject(this); }
        }
        public GetPlayerPublicBinaryRecordsV1.GetPlayerPublicBinaryRecordsV1Builder GetPlayerPublicBinaryRecordsV1Op
        {
            get { return Operation.GetPlayerPublicBinaryRecordsV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsBulkGetPlayerBinaryRecordResponse? BulkGetPlayerPublicBinaryRecordsV1(BulkGetPlayerPublicBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetPlayerBinaryRecordResponse?> BulkGetPlayerPublicBinaryRecordsV1Async(BulkGetPlayerPublicBinaryRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListPlayerBinaryRecordsResponse? ListMyBinaryRecordsV1(ListMyBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListPlayerBinaryRecordsResponse?> ListMyBinaryRecordsV1Async(ListMyBinaryRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkGetPlayerBinaryRecordResponse? BulkGetMyBinaryRecordV1(BulkGetMyBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetPlayerBinaryRecordResponse?> BulkGetMyBinaryRecordV1Async(BulkGetMyBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? PostPlayerBinaryRecordV1(PostPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUploadBinaryRecordResponse?> PostPlayerBinaryRecordV1Async(PostPlayerBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListPlayerBinaryRecordsResponse? ListOtherPlayerPublicBinaryRecordsV1(ListOtherPlayerPublicBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListPlayerBinaryRecordsResponse?> ListOtherPlayerPublicBinaryRecordsV1Async(ListOtherPlayerPublicBinaryRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkGetPlayerBinaryRecordResponse? BulkGetOtherPlayerPublicBinaryRecordsV1(BulkGetOtherPlayerPublicBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetPlayerBinaryRecordResponse?> BulkGetOtherPlayerPublicBinaryRecordsV1Async(BulkGetOtherPlayerPublicBinaryRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? GetPlayerBinaryRecordV1(GetPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlayerBinaryRecordResponse?> GetPlayerBinaryRecordV1Async(GetPlayerBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? PutPlayerBinaryRecordV1(PutPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlayerBinaryRecordResponse?> PutPlayerBinaryRecordV1Async(PutPlayerBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlayerBinaryRecordV1(DeletePlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeletePlayerBinaryRecordV1Async(DeletePlayerBinaryRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? PutPlayerBinaryRecorMetadataV1(PutPlayerBinaryRecorMetadataV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlayerBinaryRecordResponse?> PutPlayerBinaryRecorMetadataV1Async(PutPlayerBinaryRecorMetadataV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? PostPlayerBinaryPresignedURLV1(PostPlayerBinaryPresignedURLV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUploadBinaryRecordResponse?> PostPlayerBinaryPresignedURLV1Async(PostPlayerBinaryPresignedURLV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? GetPlayerPublicBinaryRecordsV1(GetPlayerPublicBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlayerBinaryRecordResponse?> GetPlayerPublicBinaryRecordsV1Async(GetPlayerPublicBinaryRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}