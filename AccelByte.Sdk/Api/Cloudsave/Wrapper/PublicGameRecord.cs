// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PublicGameRecord {
        private readonly AccelByteSDK _sdk;

        public PublicGameRecord(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
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