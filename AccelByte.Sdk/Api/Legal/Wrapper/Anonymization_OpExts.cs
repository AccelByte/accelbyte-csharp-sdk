// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalAnonymization_OpExts
    {
        public static void Execute(
            this AnonymizeUserAgreement.AnonymizeUserAgreementBuilder builder,
            string userId
        )
        {
            AnonymizeUserAgreement op = builder.Build(
                userId
            );

            ((Legal.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeUserAgreement(op);
        }

    }
}