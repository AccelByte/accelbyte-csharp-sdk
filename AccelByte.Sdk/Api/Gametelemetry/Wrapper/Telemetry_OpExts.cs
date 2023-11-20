// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;
using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GametelemetryTelemetry_OpExts
    {
        public static void Execute(
            this GetNamespacesGameTelemetryV1AdminNamespacesGet.GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder builder
        )
        {
            GetNamespacesGameTelemetryV1AdminNamespacesGet op = builder.Build(
            );

            ((Gametelemetry.Wrapper.Telemetry)builder.WrapperObject!).GetNamespacesGameTelemetryV1AdminNamespacesGet(op);
        }
        public static void Execute(
            this GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder builder,
            string namespace_
        )
        {
            GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet op = builder.Build(
                namespace_
            );

            ((Gametelemetry.Wrapper.Telemetry)builder.WrapperObject!).GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(op);
        }
    }
}