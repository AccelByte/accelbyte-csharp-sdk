// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalBaseLegalPoliciesWithNamespace_OpExts
    {
        public static List<Legal.Model.RetrieveBasePolicyResponse>? Execute(
            this RetrieveAllLegalPoliciesByNamespace.RetrieveAllLegalPoliciesByNamespaceBuilder builder,
            string namespace_
        )
        {
            RetrieveAllLegalPoliciesByNamespace op = builder.Build(
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveAllLegalPoliciesByNamespace(op);
        }
        public static async Task<List<Legal.Model.RetrieveBasePolicyResponse>?> ExecuteAsync(
            this RetrieveAllLegalPoliciesByNamespace.RetrieveAllLegalPoliciesByNamespaceBuilder builder,
            string namespace_
        )
        {
            RetrieveAllLegalPoliciesByNamespace op = builder.Build(
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveAllLegalPoliciesByNamespaceAsync(op);
        }
        public static Legal.Model.CreateBasePolicyResponse? Execute(
            this CreatePolicy1.CreatePolicy1Builder builder,
            string namespace_
        )
        {
            CreatePolicy1 op = builder.Build(
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).CreatePolicy1(op);
        }
        public static async Task<Legal.Model.CreateBasePolicyResponse?> ExecuteAsync(
            this CreatePolicy1.CreatePolicy1Builder builder,
            string namespace_
        )
        {
            CreatePolicy1 op = builder.Build(
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).CreatePolicy1Async(op);
        }
        public static Legal.Model.RetrieveBasePolicyResponse? Execute(
            this RetrieveSinglePolicy1.RetrieveSinglePolicy1Builder builder,
            string basePolicyId,
            string namespace_
        )
        {
            RetrieveSinglePolicy1 op = builder.Build(
                basePolicyId,
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveSinglePolicy1(op);
        }
        public static async Task<Legal.Model.RetrieveBasePolicyResponse?> ExecuteAsync(
            this RetrieveSinglePolicy1.RetrieveSinglePolicy1Builder builder,
            string basePolicyId,
            string namespace_
        )
        {
            RetrieveSinglePolicy1 op = builder.Build(
                basePolicyId,
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveSinglePolicy1Async(op);
        }
        public static void Execute(
            this DeleteBasePolicy.DeleteBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            DeleteBasePolicy op = builder.Build(
                basePolicyId,
                namespace_
            );

            ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).DeleteBasePolicy(op);
        }
        public static async Task ExecuteAsync(
            this DeleteBasePolicy.DeleteBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            DeleteBasePolicy op = builder.Build(
                basePolicyId,
                namespace_
            );

            await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).DeleteBasePolicyAsync(op);
        }
        public static Legal.Model.UpdateBasePolicyResponse? Execute(
            this PartialUpdatePolicy1.PartialUpdatePolicy1Builder builder,
            string basePolicyId,
            string namespace_
        )
        {
            PartialUpdatePolicy1 op = builder.Build(
                basePolicyId,
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).PartialUpdatePolicy1(op);
        }
        public static async Task<Legal.Model.UpdateBasePolicyResponse?> ExecuteAsync(
            this PartialUpdatePolicy1.PartialUpdatePolicy1Builder builder,
            string basePolicyId,
            string namespace_
        )
        {
            PartialUpdatePolicy1 op = builder.Build(
                basePolicyId,
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).PartialUpdatePolicy1Async(op);
        }
        public static Legal.Model.RetrievePolicyResponse? Execute(
            this RetrievePolicyCountry1.RetrievePolicyCountry1Builder builder,
            string basePolicyId,
            string countryCode,
            string namespace_
        )
        {
            RetrievePolicyCountry1 op = builder.Build(
                basePolicyId,
                countryCode,
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrievePolicyCountry1(op);
        }
        public static async Task<Legal.Model.RetrievePolicyResponse?> ExecuteAsync(
            this RetrievePolicyCountry1.RetrievePolicyCountry1Builder builder,
            string basePolicyId,
            string countryCode,
            string namespace_
        )
        {
            RetrievePolicyCountry1 op = builder.Build(
                basePolicyId,
                countryCode,
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrievePolicyCountry1Async(op);
        }
        public static List<Legal.Model.RetrievePoliciesFromBasePolicyResponse>? Execute(
            this RetrieveAllPoliciesFromBasePolicy.RetrieveAllPoliciesFromBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            RetrieveAllPoliciesFromBasePolicy op = builder.Build(
                basePolicyId,
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveAllPoliciesFromBasePolicy(op);
        }
        public static async Task<List<Legal.Model.RetrievePoliciesFromBasePolicyResponse>?> ExecuteAsync(
            this RetrieveAllPoliciesFromBasePolicy.RetrieveAllPoliciesFromBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            RetrieveAllPoliciesFromBasePolicy op = builder.Build(
                basePolicyId,
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveAllPoliciesFromBasePolicyAsync(op);
        }
        public static Legal.Model.CreatePolicyResponse? Execute(
            this CreatePolicyUnderBasePolicy.CreatePolicyUnderBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            CreatePolicyUnderBasePolicy op = builder.Build(
                basePolicyId,
                namespace_
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).CreatePolicyUnderBasePolicy(op);
        }
        public static async Task<Legal.Model.CreatePolicyResponse?> ExecuteAsync(
            this CreatePolicyUnderBasePolicy.CreatePolicyUnderBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            CreatePolicyUnderBasePolicy op = builder.Build(
                basePolicyId,
                namespace_
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).CreatePolicyUnderBasePolicyAsync(op);
        }
        public static List<Legal.Model.RetrievePolicyTypeResponse>? Execute(
            this RetrieveAllPolicyTypes1.RetrieveAllPolicyTypes1Builder builder,
            string namespace_,
            int limit
        )
        {
            RetrieveAllPolicyTypes1 op = builder.Build(
                namespace_,
                limit
            );

            return ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveAllPolicyTypes1(op);
        }
        public static async Task<List<Legal.Model.RetrievePolicyTypeResponse>?> ExecuteAsync(
            this RetrieveAllPolicyTypes1.RetrieveAllPolicyTypes1Builder builder,
            string namespace_,
            int limit
        )
        {
            RetrieveAllPolicyTypes1 op = builder.Build(
                namespace_,
                limit
            );

            return await ((Legal.Wrapper.BaseLegalPoliciesWithNamespace)builder.WrapperObject!).RetrieveAllPolicyTypes1Async(op);
        }
    }
}