// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public IndirectBulkAcceptVersionedPolicyV2.IndirectBulkAcceptVersionedPolicyV2Builder IndirectBulkAcceptVersionedPolicyV2Op
        {
            get { return Operation.IndirectBulkAcceptVersionedPolicyV2.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder IndirectBulkAcceptVersionedPolicy1Op
        {
            get { return Operation.IndirectBulkAcceptVersionedPolicy1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void ChangePreferenceConsent(ChangePreferenceConsent input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ChangePreferenceConsentAsync(ChangePreferenceConsent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAcceptedAgreements(RetrieveAcceptedAgreements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveAcceptedAgreementResponse>?> RetrieveAcceptedAgreementsAsync(RetrieveAcceptedAgreements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PagedRetrieveUserAcceptedAgreementResponse? RetrieveAllUsersByPolicyVersion(RetrieveAllUsersByPolicyVersion input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PagedRetrieveUserAcceptedAgreementResponse?> RetrieveAllUsersByPolicyVersionAsync(RetrieveAllUsersByPolicyVersion input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ChangePreferenceConsent1(ChangePreferenceConsent1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ChangePreferenceConsent1Async(ChangePreferenceConsent1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AcceptVersionedPolicy(AcceptVersionedPolicy input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AcceptVersionedPolicyAsync(AcceptVersionedPolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAgreementsPublic(RetrieveAgreementsPublic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveAcceptedAgreementResponse>?> RetrieveAgreementsPublicAsync(RetrieveAgreementsPublic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? BulkAcceptVersionedPolicy(BulkAcceptVersionedPolicy input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AcceptAgreementResponse?> BulkAcceptVersionedPolicyAsync(BulkAcceptVersionedPolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicyV2(IndirectBulkAcceptVersionedPolicyV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AcceptAgreementResponse?> IndirectBulkAcceptVersionedPolicyV2Async(IndirectBulkAcceptVersionedPolicyV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy1(IndirectBulkAcceptVersionedPolicy1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AcceptAgreementResponse?> IndirectBulkAcceptVersionedPolicy1Async(IndirectBulkAcceptVersionedPolicy1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}