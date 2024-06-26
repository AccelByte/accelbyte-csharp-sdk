// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicLikeV2
    {
        private readonly AccelByteSDK _sdk;

        public PublicLikeV2(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicListContentLikeV2.PublicListContentLikeV2Builder PublicListContentLikeV2Op
        {
            get { return Operation.PublicListContentLikeV2.Builder.SetWrapperObject(this); }
        }
        public UpdateContentLikeStatusV2.UpdateContentLikeStatusV2Builder UpdateContentLikeStatusV2Op
        {
            get { return Operation.UpdateContentLikeStatusV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPaginatedContentLikersResponse? PublicListContentLikeV2(PublicListContentLikeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContentLikersResponse?> PublicListContentLikeV2Async(PublicListContentLikeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentLikeResponse? UpdateContentLikeStatusV2(UpdateContentLikeStatusV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsContentLikeResponse?> UpdateContentLikeStatusV2Async(UpdateContentLikeStatusV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}