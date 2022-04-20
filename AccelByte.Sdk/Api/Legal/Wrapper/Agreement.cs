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
}