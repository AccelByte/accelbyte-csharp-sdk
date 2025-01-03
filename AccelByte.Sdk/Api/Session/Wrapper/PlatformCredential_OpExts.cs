// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionPlatformCredential_OpExts
    {
        public static Session.Model.ModelsPlatformCredentials? Execute(
            this AdminGetPlatformCredentials.AdminGetPlatformCredentialsBuilder builder,
            string namespace_
        )
        {
            AdminGetPlatformCredentials op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminGetPlatformCredentials(op);
        }
        public static async Task<Session.Model.ModelsPlatformCredentials?> ExecuteAsync(
            this AdminGetPlatformCredentials.AdminGetPlatformCredentialsBuilder builder,
            string namespace_
        )
        {
            AdminGetPlatformCredentials op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminGetPlatformCredentialsAsync(op);
        }
        public static Session.Model.ModelsPlatformCredentials? Execute(
            this AdminUpdatePlatformCredentials.AdminUpdatePlatformCredentialsBuilder builder,
            ApimodelsPutPlatformCredentialsRequest body,
            string namespace_
        )
        {
            AdminUpdatePlatformCredentials op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminUpdatePlatformCredentials(op);
        }
        public static async Task<Session.Model.ModelsPlatformCredentials?> ExecuteAsync(
            this AdminUpdatePlatformCredentials.AdminUpdatePlatformCredentialsBuilder builder,
            ApimodelsPutPlatformCredentialsRequest body,
            string namespace_
        )
        {
            AdminUpdatePlatformCredentials op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminUpdatePlatformCredentialsAsync(op);
        }
        public static void Execute(
            this AdminDeletePlatformCredentials.AdminDeletePlatformCredentialsBuilder builder,
            string namespace_
        )
        {
            AdminDeletePlatformCredentials op = builder.Build(
                namespace_
            );

            ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminDeletePlatformCredentials(op);
        }
        public static async Task ExecuteAsync(
            this AdminDeletePlatformCredentials.AdminDeletePlatformCredentialsBuilder builder,
            string namespace_
        )
        {
            AdminDeletePlatformCredentials op = builder.Build(
                namespace_
            );

            await ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminDeletePlatformCredentialsAsync(op);
        }
        public static void Execute(
            this AdminDeletePlatformCredentialsByPlatformId.AdminDeletePlatformCredentialsByPlatformIdBuilder builder,
            string namespace_,
            string platformId
        )
        {
            AdminDeletePlatformCredentialsByPlatformId op = builder.Build(
                namespace_,
                platformId
            );

            ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminDeletePlatformCredentialsByPlatformId(op);
        }
        public static async Task ExecuteAsync(
            this AdminDeletePlatformCredentialsByPlatformId.AdminDeletePlatformCredentialsByPlatformIdBuilder builder,
            string namespace_,
            string platformId
        )
        {
            AdminDeletePlatformCredentialsByPlatformId op = builder.Build(
                namespace_,
                platformId
            );

            await ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminDeletePlatformCredentialsByPlatformIdAsync(op);
        }
        public static Session.Model.ApimodelsXblCertificateResponseBody? Execute(
            this AdminSyncPlatformCredentials.AdminSyncPlatformCredentialsBuilder builder,
            string namespace_,
            string platformId
        )
        {
            AdminSyncPlatformCredentials op = builder.Build(
                namespace_,
                platformId
            );

            return ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminSyncPlatformCredentials(op);
        }
        public static async Task<Session.Model.ApimodelsXblCertificateResponseBody?> ExecuteAsync(
            this AdminSyncPlatformCredentials.AdminSyncPlatformCredentialsBuilder builder,
            string namespace_,
            string platformId
        )
        {
            AdminSyncPlatformCredentials op = builder.Build(
                namespace_,
                platformId
            );

            return await ((Session.Wrapper.PlatformCredential)builder.WrapperObject!).AdminSyncPlatformCredentialsAsync(op);
        }
    }
}