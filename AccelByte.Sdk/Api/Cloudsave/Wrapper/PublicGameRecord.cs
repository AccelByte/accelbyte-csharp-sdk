// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PublicGameRecord
    {
        private readonly AccelByteSDK _sdk;

        public PublicGameRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGameRecordsBulk.GetGameRecordsBulkBuilder GetGameRecordsBulkOp
        {
            get { return Operation.GetGameRecordsBulk.Builder.SetWrapperObject(this); }
        }
        public GetGameRecordHandlerV1.GetGameRecordHandlerV1Builder GetGameRecordHandlerV1Op
        {
            get { return Operation.GetGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PutGameRecordHandlerV1.PutGameRecordHandlerV1Builder PutGameRecordHandlerV1Op
        {
            get { return Operation.PutGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PostGameRecordHandlerV1.PostGameRecordHandlerV1Builder PostGameRecordHandlerV1Op
        {
            get { return Operation.PostGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGameRecordHandlerV1.DeleteGameRecordHandlerV1Builder DeleteGameRecordHandlerV1Op
        {
            get { return Operation.DeleteGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsBulkGetGameRecordResponse? GetGameRecordsBulk(GetGameRecordsBulk input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetGameRecordResponse?> GetGameRecordsBulkAsync(GetGameRecordsBulk input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? GetGameRecordHandlerV1(GetGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordResponse?> GetGameRecordHandlerV1Async(GetGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGameRecordResponse<T1>? GetGameRecordHandlerV1<T1>(GetGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordResponse<T1>?> GetGameRecordHandlerV1Async<T1>(GetGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? PutGameRecordHandlerV1(PutGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordResponse?> PutGameRecordHandlerV1Async(PutGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGameRecordResponse<T1>? PutGameRecordHandlerV1<T1>(PutGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordResponse<T1>?> PutGameRecordHandlerV1Async<T1>(PutGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? PostGameRecordHandlerV1(PostGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordResponse?> PostGameRecordHandlerV1Async(PostGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGameRecordResponse<T1>? PostGameRecordHandlerV1<T1>(PostGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordResponse<T1>?> PostGameRecordHandlerV1Async<T1>(PostGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGameRecordHandlerV1(DeleteGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGameRecordHandlerV1Async(DeleteGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}