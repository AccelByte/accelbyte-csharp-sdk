// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SocialGlobalStatistic_OpExts
    {
        public static Social.Model.GlobalStatItemPagingSlicedResult? Execute(
            this GetGlobalStatItems.GetGlobalStatItemsBuilder builder,
            string namespace_
        )
        {
            GetGlobalStatItems op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.GlobalStatistic)builder.WrapperObject!).GetGlobalStatItems(op);
        }

    }
}