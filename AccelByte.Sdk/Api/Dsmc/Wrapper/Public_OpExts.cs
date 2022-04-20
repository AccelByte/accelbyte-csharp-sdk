// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcPublic_OpExts
    {
        public static Dsmc.Model.ModelsDefaultProvider? Execute(
            this GetDefaultProvider.GetDefaultProviderBuilder builder
        )
        {
            GetDefaultProvider op = builder.Build(
            );

            return ((Dsmc.Wrapper.Public)builder.WrapperObject!).GetDefaultProvider(op);
        }

        public static List<string>? Execute(
            this ListProviders.ListProvidersBuilder builder
        )
        {
            ListProviders op = builder.Build(
            );

            return ((Dsmc.Wrapper.Public)builder.WrapperObject!).ListProviders(op);
        }

        public static Dsmc.Model.ModelsDefaultProvider? Execute(
            this ListProvidersByRegion.ListProvidersByRegionBuilder builder,
            string region
        )
        {
            ListProvidersByRegion op = builder.Build(
                region
            );

            return ((Dsmc.Wrapper.Public)builder.WrapperObject!).ListProvidersByRegion(op);
        }

    }
}