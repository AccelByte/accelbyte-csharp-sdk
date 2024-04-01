// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class AdminConfigurations
    {
        private readonly AccelByteSDK _sdk;

        public AdminConfigurations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Get.GetBuilder GetOp
        {
            get { return Operation.Get.Builder.SetWrapperObject(this); }
        }
        public Upsert.UpsertBuilder UpsertOp
        {
            get { return Operation.Upsert.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.RestapiConfigResponse? Get(Get input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiConfigResponse?> GetAsync(Get input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiConfigResponse? Upsert(Upsert input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiConfigResponse?> UpsertAsync(Upsert input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}