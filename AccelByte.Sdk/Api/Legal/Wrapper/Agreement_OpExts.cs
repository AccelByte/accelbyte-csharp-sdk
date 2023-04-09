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
    public static class LegalAgreement_OpExts
    {
        public static void Execute(
            this ChangePreferenceConsent.ChangePreferenceConsentBuilder builder,
            string namespace_,
            string userId
        )
        {
            ChangePreferenceConsent op = builder.Build(
                namespace_,
                userId
            );

            ((Legal.Wrapper.Agreement)builder.WrapperObject!).ChangePreferenceConsent(op);
        }
        public static List<Legal.Model.RetrieveAcceptedAgreementResponse>? Execute(
            this RetrieveAcceptedAgreements.RetrieveAcceptedAgreementsBuilder builder,
            string userId
        )
        {
            RetrieveAcceptedAgreements op = builder.Build(
                userId
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).RetrieveAcceptedAgreements(op);
        }
        public static Legal.Model.PagedRetrieveUserAcceptedAgreementResponse? Execute(
            this RetrieveAllUsersByPolicyVersion.RetrieveAllUsersByPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            RetrieveAllUsersByPolicyVersion op = builder.Build(
                policyVersionId
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).RetrieveAllUsersByPolicyVersion(op);
        }
        public static void Execute(
            this ChangePreferenceConsent1.ChangePreferenceConsent1Builder builder
        )
        {
            ChangePreferenceConsent1 op = builder.Build(
            );

            ((Legal.Wrapper.Agreement)builder.WrapperObject!).ChangePreferenceConsent1(op);
        }
        public static void Execute(
            this AcceptVersionedPolicy.AcceptVersionedPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            AcceptVersionedPolicy op = builder.Build(
                localizedPolicyVersionId
            );

            ((Legal.Wrapper.Agreement)builder.WrapperObject!).AcceptVersionedPolicy(op);
        }
        public static List<Legal.Model.RetrieveAcceptedAgreementResponse>? Execute(
            this RetrieveAgreementsPublic.RetrieveAgreementsPublicBuilder builder
        )
        {
            RetrieveAgreementsPublic op = builder.Build(
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).RetrieveAgreementsPublic(op);
        }
        public static Legal.Model.AcceptAgreementResponse? Execute(
            this BulkAcceptVersionedPolicy.BulkAcceptVersionedPolicyBuilder builder
        )
        {
            BulkAcceptVersionedPolicy op = builder.Build(
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).BulkAcceptVersionedPolicy(op);
        }

        public static Legal.Model.AcceptAgreementResponse<T1>? Execute<T1>(
            this BulkAcceptVersionedPolicy.BulkAcceptVersionedPolicyBuilder builder
        )
        {
            BulkAcceptVersionedPolicy op = builder.Build(
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).BulkAcceptVersionedPolicy<T1>(op);
        }
        public static Legal.Model.AcceptAgreementResponse? Execute(
            this IndirectBulkAcceptVersionedPolicyV2.IndirectBulkAcceptVersionedPolicyV2Builder builder,
            string clientId,
            string countryCode,
            string namespace_,
            string userId
        )
        {
            IndirectBulkAcceptVersionedPolicyV2 op = builder.Build(
                clientId,
                countryCode,
                namespace_,
                userId
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicyV2(op);
        }

        public static Legal.Model.AcceptAgreementResponse<T1>? Execute<T1>(
            this IndirectBulkAcceptVersionedPolicyV2.IndirectBulkAcceptVersionedPolicyV2Builder builder,
            string clientId,
            string countryCode,
            string namespace_,
            string userId
        )
        {
            IndirectBulkAcceptVersionedPolicyV2 op = builder.Build(
                clientId,
                countryCode,
                namespace_,
                userId
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicyV2<T1>(op);
        }
        public static Legal.Model.AcceptAgreementResponse? Execute(
            this IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder builder,
            string userId
        )
        {
            IndirectBulkAcceptVersionedPolicy1 op = builder.Build(
                userId
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicy1(op);
        }

        public static Legal.Model.AcceptAgreementResponse<T1>? Execute<T1>(
            this IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder builder,
            string userId
        )
        {
            IndirectBulkAcceptVersionedPolicy1 op = builder.Build(
                userId
            );

            return ((Legal.Wrapper.Agreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicy1<T1>(op);
        }
    }
}