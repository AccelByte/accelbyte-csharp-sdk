// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Csm.Wrapper
{
    public class ImageV2
    {
        private readonly AccelByteSDK _sdk;

        public ImageV2(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAppImageListV2.GetAppImageListV2Builder GetAppImageListV2Op
        {
            get { return Operation.GetAppImageListV2.Builder.SetWrapperObject(this); }
        }
        public DeleteAppImagesV2.DeleteAppImagesV2Builder DeleteAppImagesV2Op
        {
            get { return Operation.DeleteAppImagesV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelGetAppImageListV2Response? GetAppImageListV2(GetAppImageListV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelGetAppImageListV2Response?> GetAppImageListV2Async(GetAppImageListV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAppImagesV2(DeleteAppImagesV2 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteAppImagesV2Async(DeleteAppImagesV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}