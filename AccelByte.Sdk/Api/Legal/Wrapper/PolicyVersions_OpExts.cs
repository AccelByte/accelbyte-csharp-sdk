// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalPolicyVersions_OpExts
    {
        public static Legal.Model.UpdatePolicyVersionResponse? Execute(
            this UpdatePolicyVersion.UpdatePolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            UpdatePolicyVersion op = builder.Build(
                policyVersionId
            );

            return ((Legal.Wrapper.PolicyVersions)builder.WrapperObject!).UpdatePolicyVersion(op);
        }

        public static void Execute(
            this PublishPolicyVersion.PublishPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PublishPolicyVersion op = builder.Build(
                policyVersionId
            );

            ((Legal.Wrapper.PolicyVersions)builder.WrapperObject!).PublishPolicyVersion(op);
        }

        public static List<Legal.Model.RetrievePolicyVersionResponse>? Execute(
            this RetrieveSinglePolicyVersion.RetrieveSinglePolicyVersionBuilder builder,
            string policyId
        )
        {
            RetrieveSinglePolicyVersion op = builder.Build(
                policyId
            );

            return ((Legal.Wrapper.PolicyVersions)builder.WrapperObject!).RetrieveSinglePolicyVersion(op);
        }

        public static Legal.Model.CreatePolicyVersionResponse? Execute(
            this CreatePolicyVersion.CreatePolicyVersionBuilder builder,
            string policyId
        )
        {
            CreatePolicyVersion op = builder.Build(
                policyId
            );

            return ((Legal.Wrapper.PolicyVersions)builder.WrapperObject!).CreatePolicyVersion(op);
        }

        public static List<Legal.Model.RetrievePolicyVersionResponse>? Execute(
            this RetrievePolicyVersions.RetrievePolicyVersionsBuilder builder
        )
        {
            RetrievePolicyVersions op = builder.Build(
            );

            return ((Legal.Wrapper.PolicyVersions)builder.WrapperObject!).RetrievePolicyVersions(op);
        }

    }
}