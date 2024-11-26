// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Csm.Wrapper
{
    public class Image
    {
        private readonly AccelByteSDK _sdk;

        public Image(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetAppImageListV1.GetAppImageListV1Builder GetAppImageListV1Op
        {
            get { return Operation.GetAppImageListV1.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DeleteAppImagesV1.DeleteAppImagesV1Builder DeleteAppImagesV1Op
        {
            get { return Operation.DeleteAppImagesV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.GeneratedGetAppImageListV1Response? GetAppImageListV1(GetAppImageListV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GeneratedGetAppImageListV1Response?> GetAppImageListV1Async(GetAppImageListV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void DeleteAppImagesV1(DeleteAppImagesV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteAppImagesV1Async(DeleteAppImagesV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
    }
}