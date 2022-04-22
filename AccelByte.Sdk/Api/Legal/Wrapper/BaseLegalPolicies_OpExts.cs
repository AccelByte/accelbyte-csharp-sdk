// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalBaseLegalPolicies_OpExts
    {
        public static List<Legal.Model.RetrieveBasePolicyResponse>? Execute(
            this RetrieveAllLegalPolicies.RetrieveAllLegalPoliciesBuilder builder
        )
        {
            RetrieveAllLegalPolicies op = builder.Build(
            );

            return ((Legal.Wrapper.BaseLegalPolicies)builder.WrapperObject!).RetrieveAllLegalPolicies(op);
        }

        public static Legal.Model.CreateBasePolicyResponse? Execute(
            this CreatePolicy.CreatePolicyBuilder builder
        )
        {
            CreatePolicy op = builder.Build(
            );

            return ((Legal.Wrapper.BaseLegalPolicies)builder.WrapperObject!).CreatePolicy(op);
        }

        public static Legal.Model.RetrieveBasePolicyResponse? Execute(
            this RetrieveSinglePolicy.RetrieveSinglePolicyBuilder builder,
            string basePolicyId
        )
        {
            RetrieveSinglePolicy op = builder.Build(
                basePolicyId
            );

            return ((Legal.Wrapper.BaseLegalPolicies)builder.WrapperObject!).RetrieveSinglePolicy(op);
        }

        public static Legal.Model.UpdateBasePolicyResponse? Execute(
            this PartialUpdatePolicy.PartialUpdatePolicyBuilder builder,
            string basePolicyId
        )
        {
            PartialUpdatePolicy op = builder.Build(
                basePolicyId
            );

            return ((Legal.Wrapper.BaseLegalPolicies)builder.WrapperObject!).PartialUpdatePolicy(op);
        }

        public static Legal.Model.RetrievePolicyResponse? Execute(
            this RetrievePolicyCountry.RetrievePolicyCountryBuilder builder,
            string basePolicyId,
            string countryCode
        )
        {
            RetrievePolicyCountry op = builder.Build(
                basePolicyId,
                countryCode
            );

            return ((Legal.Wrapper.BaseLegalPolicies)builder.WrapperObject!).RetrievePolicyCountry(op);
        }

        public static List<Legal.Model.RetrievePolicyTypeResponse>? Execute(
            this RetrieveAllPolicyTypes.RetrieveAllPolicyTypesBuilder builder,
            int limit
        )
        {
            RetrieveAllPolicyTypes op = builder.Build(
                limit
            );

            return ((Legal.Wrapper.BaseLegalPolicies)builder.WrapperObject!).RetrieveAllPolicyTypes(op);
        }

    }
}