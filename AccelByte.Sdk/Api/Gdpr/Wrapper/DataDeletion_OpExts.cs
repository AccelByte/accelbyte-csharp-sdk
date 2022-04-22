// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GdprDataDeletion_OpExts
    {
        public static Gdpr.Model.ModelsListDeletionDataResponse? Execute(
            this AdminGetListDeletionDataRequest.AdminGetListDeletionDataRequestBuilder builder,
            string namespace_
        )
        {
            AdminGetListDeletionDataRequest op = builder.Build(
                namespace_
            );

            return ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).AdminGetListDeletionDataRequest(op);
        }

        public static Gdpr.Model.ModelsDeletionData? Execute(
            this AdminGetUserAccountDeletionRequest.AdminGetUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserAccountDeletionRequest op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).AdminGetUserAccountDeletionRequest(op);
        }

        public static Gdpr.Model.ModelsRequestDeleteResponse? Execute(
            this AdminSubmitUserAccountDeletionRequest.AdminSubmitUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminSubmitUserAccountDeletionRequest op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).AdminSubmitUserAccountDeletionRequest(op);
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

            ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).AdminCancelUserAccountDeletionRequest(op);
        }

        public static Gdpr.Model.ModelsRequestDeleteResponse? Execute(
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

            return ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).PublicSubmitUserAccountDeletionRequest(op);
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

            ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).PublicCancelUserAccountDeletionRequest(op);
        }

        public static Gdpr.Model.ModelsDeletionStatus? Execute(
            this PublicGetUserAccountDeletionStatus.PublicGetUserAccountDeletionStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserAccountDeletionStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataDeletion)builder.WrapperObject!).PublicGetUserAccountDeletionStatus(op);
        }

    }
}