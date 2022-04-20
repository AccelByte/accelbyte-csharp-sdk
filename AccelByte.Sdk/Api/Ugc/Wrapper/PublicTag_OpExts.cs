// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicTag_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGetTagResponse? Execute(
            this GetTag.GetTagBuilder builder,
            string namespace_
        )
        {
            GetTag op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicTag)builder.WrapperObject!).GetTag(op);
        }

    }
}