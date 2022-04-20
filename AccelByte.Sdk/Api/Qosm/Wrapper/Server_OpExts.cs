// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class QosmServer_OpExts
    {
        public static void Execute(
            this Heartbeat.HeartbeatBuilder builder,
            ModelsHeartbeatRequest body
        )
        {
            Heartbeat op = builder.Build(
                body
            );

            ((Qosm.Wrapper.Server)builder.WrapperObject!).Heartbeat(op);
        }

    }
}