// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalEligibilities_OpExts
    {
        public static List<Legal.Model.RetrieveUserEligibilitiesResponse>? Execute(
            this RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder builder,
            string namespace_
        )
        {
            RetrieveEligibilitiesPublic op = builder.Build(
                namespace_
            );

            return ((Legal.Wrapper.Eligibilities)builder.WrapperObject!).RetrieveEligibilitiesPublic(op);
        }

        public static Legal.Model.RetrieveUserEligibilitiesIndirectResponse? Execute(
            this RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder builder,
            string clientId,
            string countryCode,
            string namespace_,
            string userId
        )
        {
            RetrieveEligibilitiesPublicIndirect op = builder.Build(
                clientId,
                countryCode,
                namespace_,
                userId
            );

            return ((Legal.Wrapper.Eligibilities)builder.WrapperObject!).RetrieveEligibilitiesPublicIndirect(op);
        }

    }
}