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
    public static class LegalAgreementWithNamespace_OpExts
    {
        public static List<Legal.Model.UserAgreementsResponse>? Execute(
            this RetrieveAcceptedAgreementsForMultiUsers.RetrieveAcceptedAgreementsForMultiUsersBuilder builder,
            string namespace_
        )
        {
            RetrieveAcceptedAgreementsForMultiUsers op = builder.Build(
                namespace_
            );

            return ((Legal.Wrapper.AgreementWithNamespace)builder.WrapperObject!).RetrieveAcceptedAgreementsForMultiUsers(op);
        }
        public static List<Legal.Model.RetrieveAcceptedAgreementResponse>? Execute(
            this RetrieveAcceptedAgreements1.RetrieveAcceptedAgreements1Builder builder,
            string namespace_,
            string userId
        )
        {
            RetrieveAcceptedAgreements1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Legal.Wrapper.AgreementWithNamespace)builder.WrapperObject!).RetrieveAcceptedAgreements1(op);
        }
        public static Legal.Model.PagedRetrieveUserAcceptedAgreementResponse? Execute(
            this RetrieveAllUsersByPolicyVersion1.RetrieveAllUsersByPolicyVersion1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            RetrieveAllUsersByPolicyVersion1 op = builder.Build(
                namespace_,
                policyVersionId
            );

            return ((Legal.Wrapper.AgreementWithNamespace)builder.WrapperObject!).RetrieveAllUsersByPolicyVersion1(op);
        }
    }
}