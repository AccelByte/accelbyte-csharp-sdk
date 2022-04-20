// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicDownloadCount_OpExts
    {
        public static Ugc.Model.ModelsAddDownloadCountResponse? Execute(
            this AddDownloadCount.AddDownloadCountBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AddDownloadCount op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicDownloadCount)builder.WrapperObject!).AddDownloadCount(op);
        }

    }
}