// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicType_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGetTypeResponse? Execute(
            this GetType.GetTypeBuilder builder,
            string namespace_
        )
        {
            GetType op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicType)builder.WrapperObject!).GetType(op);
        }

    }
}