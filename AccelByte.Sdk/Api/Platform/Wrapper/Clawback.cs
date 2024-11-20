// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Clawback
    {
        private readonly AccelByteSDK _sdk;

        public Clawback(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryIAPClawbackHistory.QueryIAPClawbackHistoryBuilder QueryIAPClawbackHistoryOp
        {
            get { return Operation.QueryIAPClawbackHistory.Builder.SetWrapperObject(this); }
        }
        public MockPlayStationStreamEvent.MockPlayStationStreamEventBuilder MockPlayStationStreamEventOp
        {
            get { return Operation.MockPlayStationStreamEvent.Builder.SetWrapperObject(this); }
        }
        public MockXblClawbackEvent.MockXblClawbackEventBuilder MockXblClawbackEventOp
        {
            get { return Operation.MockXblClawbackEvent.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.IAPClawbackPagingSlicedResult? QueryIAPClawbackHistory(QueryIAPClawbackHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.IAPClawbackPagingSlicedResult?> QueryIAPClawbackHistoryAsync(QueryIAPClawbackHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClawbackInfo? MockPlayStationStreamEvent(MockPlayStationStreamEvent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ClawbackInfo?> MockPlayStationStreamEventAsync(MockPlayStationStreamEvent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ClawbackInfo<T1, T2>? MockPlayStationStreamEvent<T1, T2>(MockPlayStationStreamEvent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ClawbackInfo<T1, T2>?> MockPlayStationStreamEventAsync<T1, T2>(MockPlayStationStreamEvent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClawbackInfo? MockXblClawbackEvent(MockXblClawbackEvent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ClawbackInfo?> MockXblClawbackEventAsync(MockXblClawbackEvent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ClawbackInfo<T1, T2>? MockXblClawbackEvent<T1, T2>(MockXblClawbackEvent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ClawbackInfo<T1, T2>?> MockXblClawbackEventAsync<T1, T2>(MockXblClawbackEvent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}