// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DslogmanagerDslogmanagerOperations_OpExts
    {
        public static List<Dslogmanager.Model.LogAppMessageDeclaration>? Execute(
            this PublicGetMessages.PublicGetMessagesBuilder builder
        )
        {
            PublicGetMessages op = builder.Build(
            );

            return ((Dslogmanager.Wrapper.DslogmanagerOperations)builder.WrapperObject!).PublicGetMessages(op);
        }

    }
}