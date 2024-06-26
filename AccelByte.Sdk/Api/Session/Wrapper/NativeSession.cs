// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class NativeSession
    {
        private readonly AccelByteSDK _sdk;

        public NativeSession(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetListNativeSession.AdminGetListNativeSessionBuilder AdminGetListNativeSessionOp
        {
            get { return Operation.AdminGetListNativeSession.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsNativeSessionPagingResponse? AdminGetListNativeSession(AdminGetListNativeSession input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsNativeSessionPagingResponse?> AdminGetListNativeSessionAsync(AdminGetListNativeSession input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}