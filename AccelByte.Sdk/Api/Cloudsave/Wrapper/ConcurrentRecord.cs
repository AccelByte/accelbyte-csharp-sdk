// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class ConcurrentRecord
    {
        private readonly AccelByteSDK _sdk;

        public ConcurrentRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PutGameRecordConcurrentHandlerV1.PutGameRecordConcurrentHandlerV1Builder PutGameRecordConcurrentHandlerV1Op
        {
            get { return Operation.PutGameRecordConcurrentHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PutPlayerRecordConcurrentHandlerV1.PutPlayerRecordConcurrentHandlerV1Builder PutPlayerRecordConcurrentHandlerV1Op
        {
            get { return Operation.PutPlayerRecordConcurrentHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PutPlayerPublicRecordConcurrentHandlerV1.PutPlayerPublicRecordConcurrentHandlerV1Builder PutPlayerPublicRecordConcurrentHandlerV1Op
        {
            get { return Operation.PutPlayerPublicRecordConcurrentHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void PutGameRecordConcurrentHandlerV1(PutGameRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordConcurrentUpdateResponse? PutPlayerRecordConcurrentHandlerV1(PutPlayerRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordConcurrentUpdateResponse? PutPlayerPublicRecordConcurrentHandlerV1(PutPlayerPublicRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}