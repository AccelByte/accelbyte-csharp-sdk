// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        #endregion
        
        public Model.ModelsListDeletionDataResponse? AdminGetListDeletionDataRequest(AdminGetListDeletionDataRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionData? AdminGetUserAccountDeletionRequest(AdminGetUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? AdminSubmitUserAccountDeletionRequest(AdminSubmitUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCancelUserAccountDeletionRequest(AdminCancelUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRequestDeleteResponse? PublicSubmitUserAccountDeletionRequest(PublicSubmitUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCancelUserAccountDeletionRequest(PublicCancelUserAccountDeletionRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeletionStatus? PublicGetUserAccountDeletionStatus(PublicGetUserAccountDeletionStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class DataDeletion_OperationExtensions
    {
        public static Model.ModelsListDeletionDataResponse? Execute(
            this AdminGetListDeletionDataRequest.AdminGetListDeletionDataRequestBuilder builder,
            string namespace_
        )
        {
            AdminGetListDeletionDataRequest op = builder.Build(
                namespace_
            );

            return ((DataDeletion)builder.WrapperObject!).AdminGetListDeletionDataRequest(op);
        }

        public static Model.ModelsDeletionData? Execute(
            this AdminGetUserAccountDeletionRequest.AdminGetUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserAccountDeletionRequest op = builder.Build(
                namespace_,
                userId
            );

            return ((DataDeletion)builder.WrapperObject!).AdminGetUserAccountDeletionRequest(op);
        }

        public static Model.ModelsRequestDeleteResponse? Execute(
            this AdminSubmitUserAccountDeletionRequest.AdminSubmitUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminSubmitUserAccountDeletionRequest op = builder.Build(
                namespace_,
                userId
            );

            return ((DataDeletion)builder.WrapperObject!).AdminSubmitUserAccountDeletionRequest(op);
        }

        public static void Execute(
            this AdminCancelUserAccountDeletionRequest.AdminCancelUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminCancelUserAccountDeletionRequest op = builder.Build(
                namespace_,
                userId
            );

            ((DataDeletion)builder.WrapperObject!).AdminCancelUserAccountDeletionRequest(op);
        }

        public static Model.ModelsRequestDeleteResponse? Execute(
            this PublicSubmitUserAccountDeletionRequest.PublicSubmitUserAccountDeletionRequestBuilder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PublicSubmitUserAccountDeletionRequest op = builder.Build(
                password,
                namespace_,
                userId
            );

            return ((DataDeletion)builder.WrapperObject!).PublicSubmitUserAccountDeletionRequest(op);
        }

        public static void Execute(
            this PublicCancelUserAccountDeletionRequest.PublicCancelUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCancelUserAccountDeletionRequest op = builder.Build(
                namespace_,
                userId
            );

            ((DataDeletion)builder.WrapperObject!).PublicCancelUserAccountDeletionRequest(op);
        }

        public static Model.ModelsDeletionStatus? Execute(
            this PublicGetUserAccountDeletionStatus.PublicGetUserAccountDeletionStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserAccountDeletionStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((DataDeletion)builder.WrapperObject!).PublicGetUserAccountDeletionStatus(op);
        }

    }
}