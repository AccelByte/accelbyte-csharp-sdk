// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamSSOCredential_OpExts
    {
        public static List<Iam.Model.ModelSSOPlatformCredentialResponse>? Execute(
            this RetrieveAllSSOLoginPlatformCredentialV3.RetrieveAllSSOLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllSSOLoginPlatformCredentialV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.SSOCredential)builder.WrapperObject!).RetrieveAllSSOLoginPlatformCredentialV3(op);
        }

        public static Iam.Model.ModelSSOPlatformCredentialResponse? Execute(
            this RetrieveSSOLoginPlatformCredential.RetrieveSSOLoginPlatformCredentialBuilder builder,
            string namespace_,
            string platformId
        )
        {
            RetrieveSSOLoginPlatformCredential op = builder.Build(
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.SSOCredential)builder.WrapperObject!).RetrieveSSOLoginPlatformCredential(op);
        }

        public static Iam.Model.ModelSSOPlatformCredentialResponse? Execute(
            this AddSSOLoginPlatformCredential.AddSSOLoginPlatformCredentialBuilder builder,
            ModelSSOPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            AddSSOLoginPlatformCredential op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.SSOCredential)builder.WrapperObject!).AddSSOLoginPlatformCredential(op);
        }

        public static void Execute(
            this DeleteSSOLoginPlatformCredentialV3.DeleteSSOLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            DeleteSSOLoginPlatformCredentialV3 op = builder.Build(
                namespace_,
                platformId
            );

            ((Iam.Wrapper.SSOCredential)builder.WrapperObject!).DeleteSSOLoginPlatformCredentialV3(op);
        }

        public static Iam.Model.ModelSSOPlatformCredentialResponse? Execute(
            this UpdateSSOPlatformCredential.UpdateSSOPlatformCredentialBuilder builder,
            ModelSSOPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            UpdateSSOPlatformCredential op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.SSOCredential)builder.WrapperObject!).UpdateSSOPlatformCredential(op);
        }

    }
}