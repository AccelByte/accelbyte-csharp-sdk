// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class AccountIdenfifierTag
    {
        private readonly AccelByteSDK _sdk;

        public AccountIdenfifierTag(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryTagV3.AdminQueryTagV3Builder AdminQueryTagV3Op
        {
            get { return Operation.AdminQueryTagV3.Builder.SetWrapperObject(this); }
        }
        public AdminCreateTagV3.AdminCreateTagV3Builder AdminCreateTagV3Op
        {
            get { return Operation.AdminCreateTagV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateTagV3.AdminUpdateTagV3Builder AdminUpdateTagV3Op
        {
            get { return Operation.AdminUpdateTagV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteTagV3.AdminDeleteTagV3Builder AdminDeleteTagV3Op
        {
            get { return Operation.AdminDeleteTagV3.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.AccountcommonTagsGetResponseV3? AdminQueryTagV3(AdminQueryTagV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonTagsGetResponseV3?> AdminQueryTagV3Async(AdminQueryTagV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonTagResponse? AdminCreateTagV3(AdminCreateTagV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonTagResponse?> AdminCreateTagV3Async(AdminCreateTagV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonTagResponse? AdminUpdateTagV3(AdminUpdateTagV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonTagResponse?> AdminUpdateTagV3Async(AdminUpdateTagV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteTagV3(AdminDeleteTagV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteTagV3Async(AdminDeleteTagV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}