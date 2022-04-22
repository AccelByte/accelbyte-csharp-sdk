// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalAdminUserAgreement_OpExts
    {
        public static Legal.Model.AcceptAgreementResponse? Execute(
            this IndirectBulkAcceptVersionedPolicy.IndirectBulkAcceptVersionedPolicyBuilder builder,
            string namespace_,
            string userId,
            string clientId,
            string countryCode
        )
        {
            IndirectBulkAcceptVersionedPolicy op = builder.Build(
                namespace_,
                userId,
                clientId,
                countryCode
            );

            return ((Legal.Wrapper.AdminUserAgreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicy(op);
        }

    }
}