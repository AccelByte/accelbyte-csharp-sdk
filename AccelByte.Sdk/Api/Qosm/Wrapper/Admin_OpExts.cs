// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class QosmAdmin_OpExts
    {
        public static void Execute(
            this DeleteServer.DeleteServerBuilder builder,
            string region
        )
        {
            DeleteServer op = builder.Build(
                region
            );

            ((Qosm.Wrapper.Admin)builder.WrapperObject!).DeleteServer(op);
        }

        public static void Execute(
            this SetServerAlias.SetServerAliasBuilder builder,
            ModelsSetAliasRequest body,
            string region
        )
        {
            SetServerAlias op = builder.Build(
                body,
                region
            );

            ((Qosm.Wrapper.Admin)builder.WrapperObject!).SetServerAlias(op);
        }

    }
}