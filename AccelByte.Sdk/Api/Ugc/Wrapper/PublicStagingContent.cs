// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicStagingContent
    {
        private readonly AccelByteSDK _sdk;

        public PublicStagingContent(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListUserStagingContents.ListUserStagingContentsBuilder ListUserStagingContentsOp
        {
            get { return Operation.ListUserStagingContents.Builder.SetWrapperObject(this); }
        }
        public GetUserStagingContentByID.GetUserStagingContentByIDBuilder GetUserStagingContentByIDOp
        {
            get { return Operation.GetUserStagingContentByID.Builder.SetWrapperObject(this); }
        }
        public UpdateStagingContent.UpdateStagingContentBuilder UpdateStagingContentOp
        {
            get { return Operation.UpdateStagingContent.Builder.SetWrapperObject(this); }
        }
        public DeleteUserStagingContentByID.DeleteUserStagingContentByIDBuilder DeleteUserStagingContentByIDOp
        {
            get { return Operation.DeleteUserStagingContentByID.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPaginatedListStagingContentResponse? ListUserStagingContents(ListUserStagingContents input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsStagingContentResponse? GetUserStagingContentByID(GetUserStagingContentByID input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsStagingContentResponse<T1>? GetUserStagingContentByID<T1>(GetUserStagingContentByID input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsStagingContentResponse? UpdateStagingContent(UpdateStagingContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsStagingContentResponse<T1>? UpdateStagingContent<T1>(UpdateStagingContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStagingContentByID(DeleteUserStagingContentByID input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}