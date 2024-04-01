// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class AgreementWithNamespace
    {
        private readonly AccelByteSDK _sdk;

        public AgreementWithNamespace(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveAcceptedAgreementsForMultiUsers.RetrieveAcceptedAgreementsForMultiUsersBuilder RetrieveAcceptedAgreementsForMultiUsersOp
        {
            get { return Operation.RetrieveAcceptedAgreementsForMultiUsers.Builder.SetWrapperObject(this); }
        }
        public RetrieveAcceptedAgreements1.RetrieveAcceptedAgreements1Builder RetrieveAcceptedAgreements1Op
        {
            get { return Operation.RetrieveAcceptedAgreements1.Builder.SetWrapperObject(this); }
        }
        public RetrieveAllUsersByPolicyVersion1.RetrieveAllUsersByPolicyVersion1Builder RetrieveAllUsersByPolicyVersion1Op
        {
            get { return Operation.RetrieveAllUsersByPolicyVersion1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.UserAgreementsResponse>? RetrieveAcceptedAgreementsForMultiUsers(RetrieveAcceptedAgreementsForMultiUsers input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.UserAgreementsResponse>?> RetrieveAcceptedAgreementsForMultiUsersAsync(RetrieveAcceptedAgreementsForMultiUsers input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAcceptedAgreements1(RetrieveAcceptedAgreements1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveAcceptedAgreementResponse>?> RetrieveAcceptedAgreements1Async(RetrieveAcceptedAgreements1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PagedRetrieveUserAcceptedAgreementResponse? RetrieveAllUsersByPolicyVersion1(RetrieveAllUsersByPolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PagedRetrieveUserAcceptedAgreementResponse?> RetrieveAllUsersByPolicyVersion1Async(RetrieveAllUsersByPolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}