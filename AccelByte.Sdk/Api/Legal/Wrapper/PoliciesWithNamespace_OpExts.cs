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
    public static class LegalPoliciesWithNamespace_OpExts
    {
        public static void Execute(
            this UpdatePolicy1.UpdatePolicy1Builder builder,
            string namespace_,
            string policyId
        )
        {
            UpdatePolicy1 op = builder.Build(
                namespace_,
                policyId
            );

            ((Legal.Wrapper.PoliciesWithNamespace)builder.WrapperObject!).UpdatePolicy1(op);
        }
        public static void Execute(
            this SetDefaultPolicy3.SetDefaultPolicy3Builder builder,
            string namespace_,
            string policyId
        )
        {
            SetDefaultPolicy3 op = builder.Build(
                namespace_,
                policyId
            );

            ((Legal.Wrapper.PoliciesWithNamespace)builder.WrapperObject!).SetDefaultPolicy3(op);
        }
    }
}