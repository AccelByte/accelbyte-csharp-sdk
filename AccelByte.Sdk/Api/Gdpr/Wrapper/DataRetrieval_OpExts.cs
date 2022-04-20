// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GdprDataRetrieval_OpExts
    {
        public static List<string>? Execute(
            this GetAdminEmailConfiguration.GetAdminEmailConfigurationBuilder builder,
            string namespace_
        )
        {
            GetAdminEmailConfiguration op = builder.Build(
                namespace_
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).GetAdminEmailConfiguration(op);
        }

        public static void Execute(
            this UpdateAdminEmailConfiguration.UpdateAdminEmailConfigurationBuilder builder,
            List<string> body,
            string namespace_
        )
        {
            UpdateAdminEmailConfiguration op = builder.Build(
                body,
                namespace_
            );

            ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).UpdateAdminEmailConfiguration(op);
        }

        public static void Execute(
            this SaveAdminEmailConfiguration.SaveAdminEmailConfigurationBuilder builder,
            List<string> body,
            string namespace_
        )
        {
            SaveAdminEmailConfiguration op = builder.Build(
                body,
                namespace_
            );

            ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).SaveAdminEmailConfiguration(op);
        }

        public static void Execute(
            this DeleteAdminEmailConfiguration.DeleteAdminEmailConfigurationBuilder builder,
            string namespace_,
            List<string> emails
        )
        {
            DeleteAdminEmailConfiguration op = builder.Build(
                namespace_,
                emails
            );

            ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).DeleteAdminEmailConfiguration(op);
        }

        public static Gdpr.Model.ModelsListPersonalDataResponse? Execute(
            this AdminGetListPersonalDataRequest.AdminGetListPersonalDataRequestBuilder builder,
            string namespace_
        )
        {
            AdminGetListPersonalDataRequest op = builder.Build(
                namespace_
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).AdminGetListPersonalDataRequest(op);
        }

        public static Gdpr.Model.ModelsUserPersonalDataResponse? Execute(
            this AdminGetUserPersonalDataRequests.AdminGetUserPersonalDataRequestsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserPersonalDataRequests op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).AdminGetUserPersonalDataRequests(op);
        }

        public static Gdpr.Model.ModelsDataRetrievalResponse? Execute(
            this AdminRequestDataRetrieval.AdminRequestDataRetrievalBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminRequestDataRetrieval op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).AdminRequestDataRetrieval(op);
        }

        public static void Execute(
            this AdminCancelUserPersonalDataRequest.AdminCancelUserPersonalDataRequestBuilder builder,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            AdminCancelUserPersonalDataRequest op = builder.Build(
                namespace_,
                requestDate,
                userId
            );

            ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).AdminCancelUserPersonalDataRequest(op);
        }

        public static Gdpr.Model.ModelsUserDataURL? Execute(
            this AdminGeneratePersonalDataURL.AdminGeneratePersonalDataURLBuilder builder,
            string password,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            AdminGeneratePersonalDataURL op = builder.Build(
                password,
                namespace_,
                requestDate,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).AdminGeneratePersonalDataURL(op);
        }

        public static Gdpr.Model.ModelsUserPersonalDataResponse? Execute(
            this PublicGetUserPersonalDataRequests.PublicGetUserPersonalDataRequestsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserPersonalDataRequests op = builder.Build(
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).PublicGetUserPersonalDataRequests(op);
        }

        public static Gdpr.Model.ModelsDataRetrievalResponse? Execute(
            this PublicRequestDataRetrieval.PublicRequestDataRetrievalBuilder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PublicRequestDataRetrieval op = builder.Build(
                password,
                namespace_,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).PublicRequestDataRetrieval(op);
        }

        public static Gdpr.Model.ModelsListPersonalDataResponse? Execute(
            this PublicCancelUserPersonalDataRequest.PublicCancelUserPersonalDataRequestBuilder builder,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            PublicCancelUserPersonalDataRequest op = builder.Build(
                namespace_,
                requestDate,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).PublicCancelUserPersonalDataRequest(op);
        }

        public static Gdpr.Model.ModelsUserDataURL? Execute(
            this PublicGeneratePersonalDataURL.PublicGeneratePersonalDataURLBuilder builder,
            string password,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            PublicGeneratePersonalDataURL op = builder.Build(
                password,
                namespace_,
                requestDate,
                userId
            );

            return ((Gdpr.Wrapper.DataRetrieval)builder.WrapperObject!).PublicGeneratePersonalDataURL(op);
        }

    }
}