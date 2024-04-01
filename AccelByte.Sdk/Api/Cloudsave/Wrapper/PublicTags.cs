// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PublicTags
    {
        private readonly AccelByteSDK _sdk;

        public PublicTags(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicListTagsHandlerV1.PublicListTagsHandlerV1Builder PublicListTagsHandlerV1Op
        {
            get { return Operation.PublicListTagsHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListTagsResponse? PublicListTagsHandlerV1(PublicListTagsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListTagsResponse?> PublicListTagsHandlerV1Async(PublicListTagsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}