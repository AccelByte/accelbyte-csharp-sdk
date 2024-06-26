// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class PlatformAccountClosureHistory
    {
        private readonly AccelByteSDK _sdk;

        public PlatformAccountClosureHistory(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetUserPlatformAccountClosureHistories.AdminGetUserPlatformAccountClosureHistoriesBuilder AdminGetUserPlatformAccountClosureHistoriesOp
        {
            get { return Operation.AdminGetUserPlatformAccountClosureHistories.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.DtoUserPlatformAccountClosureHistoriesResponse? AdminGetUserPlatformAccountClosureHistories(AdminGetUserPlatformAccountClosureHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DtoUserPlatformAccountClosureHistoriesResponse?> AdminGetUserPlatformAccountClosureHistoriesAsync(AdminGetUserPlatformAccountClosureHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}