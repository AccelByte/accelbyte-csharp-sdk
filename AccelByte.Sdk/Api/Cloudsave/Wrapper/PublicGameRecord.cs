// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        
        public Model.ModelsGameRecordResponse? GetGameRecordHandlerV1(GetGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PutGameRecordHandlerV1(PutGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PostGameRecordHandlerV1(PostGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGameRecordHandlerV1(DeleteGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}