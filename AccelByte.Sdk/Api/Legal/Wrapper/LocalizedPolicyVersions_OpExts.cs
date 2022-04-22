// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalLocalizedPolicyVersions_OpExts
    {
        public static List<Legal.Model.RetrieveLocalizedPolicyVersionResponse>? Execute(
            this RetrieveLocalizedPolicyVersions.RetrieveLocalizedPolicyVersionsBuilder builder,
            string policyVersionId
        )
        {
            RetrieveLocalizedPolicyVersions op = builder.Build(
                policyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).RetrieveLocalizedPolicyVersions(op);
        }

        public static Legal.Model.CreateLocalizedPolicyVersionResponse? Execute(
            this CreateLocalizedPolicyVersion.CreateLocalizedPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            CreateLocalizedPolicyVersion op = builder.Build(
                policyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).CreateLocalizedPolicyVersion(op);
        }

        public static Legal.Model.UpdateLocalizedPolicyVersionResponse? Execute(
            this RetrieveSingleLocalizedPolicyVersion.RetrieveSingleLocalizedPolicyVersionBuilder builder,
            string localizedPolicyVersionId
        )
        {
            RetrieveSingleLocalizedPolicyVersion op = builder.Build(
                localizedPolicyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).RetrieveSingleLocalizedPolicyVersion(op);
        }

        public static Legal.Model.UpdateLocalizedPolicyVersionResponse? Execute(
            this UpdateLocalizedPolicyVersion.UpdateLocalizedPolicyVersionBuilder builder,
            string localizedPolicyVersionId
        )
        {
            UpdateLocalizedPolicyVersion op = builder.Build(
                localizedPolicyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).UpdateLocalizedPolicyVersion(op);
        }

        public static Legal.Model.UploadLocalizedPolicyVersionAttachmentResponse? Execute(
            this RequestPresignedURL.RequestPresignedURLBuilder builder,
            string localizedPolicyVersionId
        )
        {
            RequestPresignedURL op = builder.Build(
                localizedPolicyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).RequestPresignedURL(op);
        }

        public static void Execute(
            this SetDefaultPolicy.SetDefaultPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            SetDefaultPolicy op = builder.Build(
                localizedPolicyVersionId
            );

            ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).SetDefaultPolicy(op);
        }

        public static Legal.Model.RetrieveLocalizedPolicyVersionPublicResponse? Execute(
            this RetrieveSingleLocalizedPolicyVersion1.RetrieveSingleLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId
        )
        {
            RetrieveSingleLocalizedPolicyVersion1 op = builder.Build(
                localizedPolicyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersions)builder.WrapperObject!).RetrieveSingleLocalizedPolicyVersion1(op);
        }

    }
}