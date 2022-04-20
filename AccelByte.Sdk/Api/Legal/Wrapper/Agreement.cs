// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Agreement
    {
        private readonly AccelByteSDK _sdk;

        public Agreement(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ChangePreferenceConsent.ChangePreferenceConsentBuilder ChangePreferenceConsentOp
        {
            get { return Operation.ChangePreferenceConsent.Builder.SetWrapperObject(this); }
        }
        public RetrieveAcceptedAgreements.RetrieveAcceptedAgreementsBuilder RetrieveAcceptedAgreementsOp
        {
            get { return Operation.RetrieveAcceptedAgreements.Builder.SetWrapperObject(this); }
        }
        public RetrieveAllUsersByPolicyVersion.RetrieveAllUsersByPolicyVersionBuilder RetrieveAllUsersByPolicyVersionOp
        {
            get { return Operation.RetrieveAllUsersByPolicyVersion.Builder.SetWrapperObject(this); }
        }
        public ChangePreferenceConsent1.ChangePreferenceConsent1Builder ChangePreferenceConsent1Op
        {
            get { return Operation.ChangePreferenceConsent1.Builder.SetWrapperObject(this); }
        }
        public AcceptVersionedPolicy.AcceptVersionedPolicyBuilder AcceptVersionedPolicyOp
        {
            get { return Operation.AcceptVersionedPolicy.Builder.SetWrapperObject(this); }
        }
        public RetrieveAgreementsPublic.RetrieveAgreementsPublicBuilder RetrieveAgreementsPublicOp
        {
            get { return Operation.RetrieveAgreementsPublic.Builder.SetWrapperObject(this); }
        }
        public BulkAcceptVersionedPolicy.BulkAcceptVersionedPolicyBuilder BulkAcceptVersionedPolicyOp
        {
            get { return Operation.BulkAcceptVersionedPolicy.Builder.SetWrapperObject(this); }
        }
        public IndirectBulkAcceptVersionedPolicyV2.IndirectBulkAcceptVersionedPolicyV2Builder IndirectBulkAcceptVersionedPolicyV2Op
        {
            get { return Operation.IndirectBulkAcceptVersionedPolicyV2.Builder.SetWrapperObject(this); }
        }
        public IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder IndirectBulkAcceptVersionedPolicy1Op
        {
            get { return Operation.IndirectBulkAcceptVersionedPolicy1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void ChangePreferenceConsent(ChangePreferenceConsent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAcceptedAgreements(RetrieveAcceptedAgreements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.PagedRetrieveUserAcceptedAgreementResponse>? RetrieveAllUsersByPolicyVersion(RetrieveAllUsersByPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ChangePreferenceConsent1(ChangePreferenceConsent1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AcceptVersionedPolicy(AcceptVersionedPolicy input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAgreementsPublic(RetrieveAgreementsPublic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? BulkAcceptVersionedPolicy(BulkAcceptVersionedPolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicyV2(IndirectBulkAcceptVersionedPolicyV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy1(IndirectBulkAcceptVersionedPolicy1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Agreement_OperationExtensions
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

            ((Agreement)builder.WrapperObject!).ChangePreferenceConsent(op);
        }

        public static List<Model.RetrieveAcceptedAgreementResponse>? Execute(
            this RetrieveAcceptedAgreements.RetrieveAcceptedAgreementsBuilder builder,
            string userId
        )
        {
            RetrieveAcceptedAgreements op = builder.Build(
                userId
            );

            return ((Agreement)builder.WrapperObject!).RetrieveAcceptedAgreements(op);
        }

        public static List<Model.PagedRetrieveUserAcceptedAgreementResponse>? Execute(
            this RetrieveAllUsersByPolicyVersion.RetrieveAllUsersByPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            RetrieveAllUsersByPolicyVersion op = builder.Build(
                policyVersionId
            );

            return ((Agreement)builder.WrapperObject!).RetrieveAllUsersByPolicyVersion(op);
        }

        public static void Execute(
            this ChangePreferenceConsent1.ChangePreferenceConsent1Builder builder
        )
        {
            ChangePreferenceConsent1 op = builder.Build(
            );

            ((Agreement)builder.WrapperObject!).ChangePreferenceConsent1(op);
        }

        public static void Execute(
            this AcceptVersionedPolicy.AcceptVersionedPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            AcceptVersionedPolicy op = builder.Build(
                localizedPolicyVersionId
            );

            ((Agreement)builder.WrapperObject!).AcceptVersionedPolicy(op);
        }

        public static List<Model.RetrieveAcceptedAgreementResponse>? Execute(
            this RetrieveAgreementsPublic.RetrieveAgreementsPublicBuilder builder
        )
        {
            RetrieveAgreementsPublic op = builder.Build(
            );

            return ((Agreement)builder.WrapperObject!).RetrieveAgreementsPublic(op);
        }

        public static Model.AcceptAgreementResponse? Execute(
            this BulkAcceptVersionedPolicy.BulkAcceptVersionedPolicyBuilder builder
        )
        {
            BulkAcceptVersionedPolicy op = builder.Build(
            );

            return ((Agreement)builder.WrapperObject!).BulkAcceptVersionedPolicy(op);
        }

        public static Model.AcceptAgreementResponse? Execute(
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

            return ((Agreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicyV2(op);
        }

        public static Model.AcceptAgreementResponse? Execute(
            this IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder builder,
            string userId
        )
        {
            IndirectBulkAcceptVersionedPolicy1 op = builder.Build(
                userId
            );

            return ((Agreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicy1(op);
        }

    }
}