// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicCreator_OpExts
    {
        public static Ugc.Model.ModelsCreatorOverviewResponse? Execute(
            this GetCreator.GetCreatorBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetCreator op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicCreator)builder.WrapperObject!).GetCreator(op);
        }

    }
}