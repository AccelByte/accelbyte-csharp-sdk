// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamThirdPartyCredential_OpExts
    {
        public static List<Iam.Model.ModelThirdPartyLoginPlatformCredentialResponse>? Execute(
            this RetrieveAllThirdPartyLoginPlatformCredentialV3.RetrieveAllThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).RetrieveAllThirdPartyLoginPlatformCredentialV3(op);
        }

        public static List<Iam.Model.ModelThirdPartyLoginPlatformCredentialResponse>? Execute(
            this RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Iam.Model.ModelThirdPartyLoginPlatformCredentialResponse? Execute(
            this RetrieveThirdPartyLoginPlatformCredentialV3.RetrieveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            RetrieveThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).RetrieveThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Iam.Model.ModelThirdPartyLoginPlatformCredentialResponse? Execute(
            this AddThirdPartyLoginPlatformCredentialV3.AddThirdPartyLoginPlatformCredentialV3Builder builder,
            ModelThirdPartyLoginPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            AddThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).AddThirdPartyLoginPlatformCredentialV3(op);
        }

        public static void Execute(
            this DeleteThirdPartyLoginPlatformCredentialV3.DeleteThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            DeleteThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_,
                platformId
            );

            ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).DeleteThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Iam.Model.ModelThirdPartyLoginPlatformCredentialResponse? Execute(
            this UpdateThirdPartyLoginPlatformCredentialV3.UpdateThirdPartyLoginPlatformCredentialV3Builder builder,
            ModelThirdPartyLoginPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            UpdateThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).UpdateThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Iam.Model.ModelPlatformDomainResponse? Execute(
            this UpdateThirdPartyLoginPlatformDomainV3.UpdateThirdPartyLoginPlatformDomainV3Builder builder,
            ModelPlatformDomainUpdateRequest body,
            string namespace_,
            string platformId
        )
        {
            UpdateThirdPartyLoginPlatformDomainV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).UpdateThirdPartyLoginPlatformDomainV3(op);
        }

        public static void Execute(
            this DeleteThirdPartyLoginPlatformDomainV3.DeleteThirdPartyLoginPlatformDomainV3Builder builder,
            ModelPlatformDomainDeleteRequest body,
            string namespace_,
            string platformId
        )
        {
            DeleteThirdPartyLoginPlatformDomainV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).DeleteThirdPartyLoginPlatformDomainV3(op);
        }

        public static List<Iam.Model.ModelPublicThirdPartyPlatformInfo>? Execute(
            this RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.ThirdPartyCredential)builder.WrapperObject!).RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(op);
        }

    }
}