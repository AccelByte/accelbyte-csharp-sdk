// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalLocalizedPolicyVersionsWithNamespace_OpExts
    {
        public static List<Legal.Model.RetrieveLocalizedPolicyVersionResponse>? Execute(
            this RetrieveLocalizedPolicyVersions1.RetrieveLocalizedPolicyVersions1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            RetrieveLocalizedPolicyVersions1 op = builder.Build(
                namespace_,
                policyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).RetrieveLocalizedPolicyVersions1(op);
        }
        public static Legal.Model.CreateLocalizedPolicyVersionResponse? Execute(
            this CreateLocalizedPolicyVersion1.CreateLocalizedPolicyVersion1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            CreateLocalizedPolicyVersion1 op = builder.Build(
                namespace_,
                policyVersionId
            );

            return ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).CreateLocalizedPolicyVersion1(op);
        }
        public static Legal.Model.RetrieveLocalizedPolicyVersionResponse? Execute(
            this RetrieveSingleLocalizedPolicyVersion1.RetrieveSingleLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            RetrieveSingleLocalizedPolicyVersion1 op = builder.Build(
                localizedPolicyVersionId,
                namespace_
            );

            return ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).RetrieveSingleLocalizedPolicyVersion1(op);
        }
        public static Legal.Model.UpdateLocalizedPolicyVersionResponse? Execute(
            this UpdateLocalizedPolicyVersion1.UpdateLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            UpdateLocalizedPolicyVersion1 op = builder.Build(
                localizedPolicyVersionId,
                namespace_
            );

            return ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).UpdateLocalizedPolicyVersion1(op);
        }
        public static Legal.Model.UploadLocalizedPolicyVersionAttachmentResponse? Execute(
            this RequestPresignedURL1.RequestPresignedURL1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            RequestPresignedURL1 op = builder.Build(
                localizedPolicyVersionId,
                namespace_
            );

            return ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).RequestPresignedURL1(op);
        }
        public static void Execute(
            this SetDefaultPolicy1.SetDefaultPolicy1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            SetDefaultPolicy1 op = builder.Build(
                localizedPolicyVersionId,
                namespace_
            );

            ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).SetDefaultPolicy1(op);
        }
        public static Legal.Model.RetrieveLocalizedPolicyVersionPublicResponse? Execute(
            this RetrieveSingleLocalizedPolicyVersion3.RetrieveSingleLocalizedPolicyVersion3Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            RetrieveSingleLocalizedPolicyVersion3 op = builder.Build(
                localizedPolicyVersionId,
                namespace_
            );

            return ((Legal.Wrapper.LocalizedPolicyVersionsWithNamespace)builder.WrapperObject!).RetrieveSingleLocalizedPolicyVersion3(op);
        }
    }
}