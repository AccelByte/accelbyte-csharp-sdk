// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcDsmcOperations_OpExts
    {
        public static List<Dsmc.Model.LogAppMessageDeclaration>? Execute(
            this PublicGetMessages.PublicGetMessagesBuilder builder
        )
        {
            PublicGetMessages op = builder.Build(
            );

            return ((Dsmc.Wrapper.DsmcOperations)builder.WrapperObject!).PublicGetMessages(op);
        }

    }
}