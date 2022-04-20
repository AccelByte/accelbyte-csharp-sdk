// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class FileUpload
    {
        private readonly AccelByteSDK _sdk;

        public FileUpload(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GeneratedUploadUrl.GeneratedUploadUrlBuilder GeneratedUploadUrlOp
        {
            get { return Operation.GeneratedUploadUrl.Builder.SetWrapperObject(this); }
        }
        public GeneratedUserUploadContentUrl.GeneratedUserUploadContentUrlBuilder GeneratedUserUploadContentUrlOp
        {
            get { return Operation.GeneratedUserUploadContentUrl.Builder.SetWrapperObject(this); }
        }
        public PublicGeneratedUploadUrl.PublicGeneratedUploadUrlBuilder PublicGeneratedUploadUrlOp
        {
            get { return Operation.PublicGeneratedUploadUrl.Builder.SetWrapperObject(this); }
        }
        public PublicGeneratedUserUploadContentUrl.PublicGeneratedUserUploadContentUrlBuilder PublicGeneratedUserUploadContentUrlOp
        {
            get { return Operation.PublicGeneratedUserUploadContentUrl.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.FileUploadUrlInfo? GeneratedUploadUrl(GeneratedUploadUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? GeneratedUserUploadContentUrl(GeneratedUserUploadContentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? PublicGeneratedUploadUrl(PublicGeneratedUploadUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? PublicGeneratedUserUploadContentUrl(PublicGeneratedUserUploadContentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}