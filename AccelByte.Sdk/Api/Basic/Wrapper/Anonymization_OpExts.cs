// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicAnonymization_OpExts
    {
        public static void Execute(
            this AnonymizeUserProfile.AnonymizeUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeUserProfile op = builder.Build(
                namespace_,
                userId
            );

            ((Basic.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeUserProfile(op);
        }

    }
}