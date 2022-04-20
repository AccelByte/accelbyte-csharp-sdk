// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcServer_OpExts
    {
        public static void Execute(
            this DeregisterLocalServer.DeregisterLocalServerBuilder builder,
            ModelsDeregisterLocalServerRequest body,
            string namespace_
        )
        {
            DeregisterLocalServer op = builder.Build(
                body,
                namespace_
            );

            ((Dsmc.Wrapper.Server)builder.WrapperObject!).DeregisterLocalServer(op);
        }

        public static Dsmc.Model.ModelsServer? Execute(
            this RegisterLocalServer.RegisterLocalServerBuilder builder,
            ModelsRegisterLocalServerRequest body,
            string namespace_
        )
        {
            RegisterLocalServer op = builder.Build(
                body,
                namespace_
            );

            return ((Dsmc.Wrapper.Server)builder.WrapperObject!).RegisterLocalServer(op);
        }

        public static Dsmc.Model.ModelsServer? Execute(
            this RegisterServer.RegisterServerBuilder builder,
            ModelsRegisterServerRequest body,
            string namespace_
        )
        {
            RegisterServer op = builder.Build(
                body,
                namespace_
            );

            return ((Dsmc.Wrapper.Server)builder.WrapperObject!).RegisterServer(op);
        }

        public static void Execute(
            this ShutdownServer.ShutdownServerBuilder builder,
            ModelsShutdownServerRequest body,
            string namespace_
        )
        {
            ShutdownServer op = builder.Build(
                body,
                namespace_
            );

            ((Dsmc.Wrapper.Server)builder.WrapperObject!).ShutdownServer(op);
        }

        public static Dsmc.Model.ModelsServerSessionResponse? Execute(
            this GetServerSession.GetServerSessionBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetServerSession op = builder.Build(
                namespace_,
                podName
            );

            return ((Dsmc.Wrapper.Server)builder.WrapperObject!).GetServerSession(op);
        }

    }
}