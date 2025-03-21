// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class LoginAllowlist
    {
        private readonly AccelByteSDK _sdk;

        public LoginAllowlist(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetLoginAllowlistV3.AdminGetLoginAllowlistV3Builder AdminGetLoginAllowlistV3Op
        {
            get { return Operation.AdminGetLoginAllowlistV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateLoginAllowlistV3.AdminUpdateLoginAllowlistV3Builder AdminUpdateLoginAllowlistV3Op
        {
            get { return Operation.AdminUpdateLoginAllowlistV3.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelLoginAllowlistResponse? AdminGetLoginAllowlistV3(AdminGetLoginAllowlistV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelLoginAllowlistResponse?> AdminGetLoginAllowlistV3Async(AdminGetLoginAllowlistV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateLoginAllowlistV3(AdminUpdateLoginAllowlistV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminUpdateLoginAllowlistV3Async(AdminUpdateLoginAllowlistV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}