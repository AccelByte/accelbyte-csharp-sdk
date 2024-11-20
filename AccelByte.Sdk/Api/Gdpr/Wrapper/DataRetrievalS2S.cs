// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class DataRetrievalS2S
    {
        private readonly AccelByteSDK _sdk;

        public DataRetrievalS2S(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public S2SGetListFinishedPersonalDataRequest.S2SGetListFinishedPersonalDataRequestBuilder S2SGetListFinishedPersonalDataRequestOp
        {
            get { return Operation.S2SGetListFinishedPersonalDataRequest.Builder.SetWrapperObject(this); }
        }
        public S2SGetDataRequestByRequestID.S2SGetDataRequestByRequestIDBuilder S2SGetDataRequestByRequestIDOp
        {
            get { return Operation.S2SGetDataRequestByRequestID.Builder.SetWrapperObject(this); }
        }
        public S2SRequestDataRetrieval.S2SRequestDataRetrievalBuilder S2SRequestDataRetrievalOp
        {
            get { return Operation.S2SRequestDataRetrieval.Builder.SetWrapperObject(this); }
        }
        public S2SGeneratePersonalDataURL.S2SGeneratePersonalDataURLBuilder S2SGeneratePersonalDataURLOp
        {
            get { return Operation.S2SGeneratePersonalDataURL.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.DtoListFinishedDataRequests? S2SGetListFinishedPersonalDataRequest(S2SGetListFinishedPersonalDataRequest input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DtoListFinishedDataRequests?> S2SGetListFinishedPersonalDataRequestAsync(S2SGetListFinishedPersonalDataRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DtoS2SDataRequestSummary? S2SGetDataRequestByRequestID(S2SGetDataRequestByRequestID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DtoS2SDataRequestSummary?> S2SGetDataRequestByRequestIDAsync(S2SGetDataRequestByRequestID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsS2SDataRetrievalResponse? S2SRequestDataRetrieval(S2SRequestDataRetrieval input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsS2SDataRetrievalResponse?> S2SRequestDataRetrievalAsync(S2SRequestDataRetrieval input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsS2SUserDataURL? S2SGeneratePersonalDataURL(S2SGeneratePersonalDataURL input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsS2SUserDataURL?> S2SGeneratePersonalDataURLAsync(S2SGeneratePersonalDataURL input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}