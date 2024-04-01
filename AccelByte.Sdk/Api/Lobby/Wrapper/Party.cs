// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Party
    {
        private readonly AccelByteSDK _sdk;

        public Party(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetPartyDataV1.AdminGetPartyDataV1Builder AdminGetPartyDataV1Op
        {
            get { return Operation.AdminGetPartyDataV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserPartyV1.AdminGetUserPartyV1Builder AdminGetUserPartyV1Op
        {
            get { return Operation.AdminGetUserPartyV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetPartyDataV1.PublicGetPartyDataV1Builder PublicGetPartyDataV1Op
        {
            get { return Operation.PublicGetPartyDataV1.Builder.SetWrapperObject(this); }
        }
        public PublicUpdatePartyAttributesV1.PublicUpdatePartyAttributesV1Builder PublicUpdatePartyAttributesV1Op
        {
            get { return Operation.PublicUpdatePartyAttributesV1.Builder.SetWrapperObject(this); }
        }
        public PublicSetPartyLimitV1.PublicSetPartyLimitV1Builder PublicSetPartyLimitV1Op
        {
            get { return Operation.PublicSetPartyLimitV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPartyData? AdminGetPartyDataV1(AdminGetPartyDataV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData?> AdminGetPartyDataV1Async(AdminGetPartyDataV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsPartyData<T1>? AdminGetPartyDataV1<T1>(AdminGetPartyDataV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData<T1>?> AdminGetPartyDataV1Async<T1>(AdminGetPartyDataV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPartyData? AdminGetUserPartyV1(AdminGetUserPartyV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData?> AdminGetUserPartyV1Async(AdminGetUserPartyV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsPartyData<T1>? AdminGetUserPartyV1<T1>(AdminGetUserPartyV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData<T1>?> AdminGetUserPartyV1Async<T1>(AdminGetUserPartyV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPartyData? PublicGetPartyDataV1(PublicGetPartyDataV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData?> PublicGetPartyDataV1Async(PublicGetPartyDataV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsPartyData<T1>? PublicGetPartyDataV1<T1>(PublicGetPartyDataV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData<T1>?> PublicGetPartyDataV1Async<T1>(PublicGetPartyDataV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPartyData? PublicUpdatePartyAttributesV1(PublicUpdatePartyAttributesV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData?> PublicUpdatePartyAttributesV1Async(PublicUpdatePartyAttributesV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsPartyData<T1>? PublicUpdatePartyAttributesV1<T1>(PublicUpdatePartyAttributesV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPartyData<T1>?> PublicUpdatePartyAttributesV1Async<T1>(PublicUpdatePartyAttributesV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSetPartyLimitV1(PublicSetPartyLimitV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicSetPartyLimitV1Async(PublicSetPartyLimitV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}