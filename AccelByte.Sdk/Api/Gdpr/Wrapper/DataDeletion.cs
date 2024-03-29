// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class DataDeletion
    {
        private readonly AccelByteSDK _sdk;

        public DataDeletion(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetListDeletionDataRequest.AdminGetListDeletionDataRequestBuilder AdminGetListDeletionDataRequestOp
        {
            get { return Operation.AdminGetListDeletionDataRequest.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserAccountDeletionRequest.AdminGetUserAccountDeletionRequestBuilder AdminGetUserAccountDeletionRequestOp
        {
            get { return Operation.AdminGetUserAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public AdminSubmitUserAccountDeletionRequest.AdminSubmitUserAccountDeletionRequestBuilder AdminSubmitUserAccountDeletionRequestOp
        {
            get { return Operation.AdminSubmitUserAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public AdminCancelUserAccountDeletionRequest.AdminCancelUserAccountDeletionRequestBuilder AdminCancelUserAccountDeletionRequestOp
        {
            get { return Operation.AdminCancelUserAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public PublicSubmitUserAccountDeletionRequest.PublicSubmitUserAccountDeletionRequestBuilder PublicSubmitUserAccountDeletionRequestOp
        {
            get { return Operation.PublicSubmitUserAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public PublicCancelUserAccountDeletionRequest.PublicCancelUserAccountDeletionRequestBuilder PublicCancelUserAccountDeletionRequestOp
        {
            get { return Operation.PublicCancelUserAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserAccountDeletionStatus.PublicGetUserAccountDeletionStatusBuilder PublicGetUserAccountDeletionStatusOp
        {
            get { return Operation.PublicGetUserAccountDeletionStatus.Builder.SetWrapperObject(this); }
        }
        public PublicSubmitMyAccountDeletionRequest.PublicSubmitMyAccountDeletionRequestBuilder PublicSubmitMyAccountDeletionRequestOp
        {
            get { return Operation.PublicSubmitMyAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public PublicCancelMyAccountDeletionRequest.PublicCancelMyAccountDeletionRequestBuilder PublicCancelMyAccountDeletionRequestOp
        {
            get { return Operation.PublicCancelMyAccountDeletionRequest.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyAccountDeletionStatus.PublicGetMyAccountDeletionStatusBuilder PublicGetMyAccountDeletionStatusOp
        {
            get { return Operation.PublicGetMyAccountDeletionStatus.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListDeletionDataResponse? AdminGetListDeletionDataRequest(AdminGetListDeletionDataRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionData? AdminGetUserAccountDeletionRequest(AdminGetUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? AdminSubmitUserAccountDeletionRequest(AdminSubmitUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCancelUserAccountDeletionRequest(AdminCancelUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? PublicSubmitUserAccountDeletionRequest(PublicSubmitUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCancelUserAccountDeletionRequest(PublicCancelUserAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionStatus? PublicGetUserAccountDeletionStatus(PublicGetUserAccountDeletionStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? PublicSubmitMyAccountDeletionRequest(PublicSubmitMyAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCancelMyAccountDeletionRequest(PublicCancelMyAccountDeletionRequest input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionStatus? PublicGetMyAccountDeletionStatus(PublicGetMyAccountDeletionStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}