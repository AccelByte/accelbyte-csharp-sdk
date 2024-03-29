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
    public static class LegalPolicies_OpExts
    {
        public static List<Legal.Model.RetrievePolicyResponse>? Execute(
            this RetrievePolicies.RetrievePoliciesBuilder builder,
            string countryCode
        )
        {
            RetrievePolicies op = builder.Build(
                countryCode
            );

            return ((Legal.Wrapper.Policies)builder.WrapperObject!).RetrievePolicies(op);
        }
        public static void Execute(
            this UpdatePolicy.UpdatePolicyBuilder builder,
            string policyId
        )
        {
            UpdatePolicy op = builder.Build(
                policyId
            );

            ((Legal.Wrapper.Policies)builder.WrapperObject!).UpdatePolicy(op);
        }
        public static void Execute(
            this SetDefaultPolicy2.SetDefaultPolicy2Builder builder,
            string policyId
        )
        {
            SetDefaultPolicy2 op = builder.Build(
                policyId
            );

            ((Legal.Wrapper.Policies)builder.WrapperObject!).SetDefaultPolicy2(op);
        }
        public static List<string>? Execute(
            this RetrieveCountryListWithPolicies.RetrieveCountryListWithPoliciesBuilder builder
        )
        {
            RetrieveCountryListWithPolicies op = builder.Build(
            );

            return ((Legal.Wrapper.Policies)builder.WrapperObject!).RetrieveCountryListWithPolicies(op);
        }
        public static List<Legal.Model.RetrievePolicyPublicResponse>? Execute(
            this RetrieveLatestPolicies.RetrieveLatestPoliciesBuilder builder,
            string countryCode
        )
        {
            RetrieveLatestPolicies op = builder.Build(
                countryCode
            );

            return ((Legal.Wrapper.Policies)builder.WrapperObject!).RetrieveLatestPolicies(op);
        }
        public static List<Legal.Model.RetrievePolicyPublicResponse>? Execute(
            this RetrieveLatestPoliciesPublic.RetrieveLatestPoliciesPublicBuilder builder,
            string namespace_
        )
        {
            RetrieveLatestPoliciesPublic op = builder.Build(
                namespace_
            );

            return ((Legal.Wrapper.Policies)builder.WrapperObject!).RetrieveLatestPoliciesPublic(op);
        }
        public static List<Legal.Model.RetrievePolicyPublicResponse>? Execute(
            this RetrieveLatestPoliciesByNamespaceAndCountryPublic.RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder builder,
            string countryCode,
            string namespace_
        )
        {
            RetrieveLatestPoliciesByNamespaceAndCountryPublic op = builder.Build(
                countryCode,
                namespace_
            );

            return ((Legal.Wrapper.Policies)builder.WrapperObject!).RetrieveLatestPoliciesByNamespaceAndCountryPublic(op);
        }
    }
}