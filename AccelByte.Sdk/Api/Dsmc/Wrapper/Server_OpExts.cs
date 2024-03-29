// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcServer_OpExts
    {
        public static Dsmc.Model.ModelsListServerResponse? Execute(
            this ListServerClient.ListServerClientBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            ListServerClient op = builder.Build(
                namespace_,
                count,
                offset
            );

            return ((Dsmc.Wrapper.Server)builder.WrapperObject!).ListServerClient(op);
        }
        public static void Execute(
            this ServerHeartbeat.ServerHeartbeatBuilder builder,
            ModelsDSHeartbeatRequest body,
            string namespace_
        )
        {
            ServerHeartbeat op = builder.Build(
                body,
                namespace_
            );

            ((Dsmc.Wrapper.Server)builder.WrapperObject!).ServerHeartbeat(op);
        }
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
        public static Dsmc.Model.ModelsServerDeploymentConfigSessionTimeoutResponse? Execute(
            this GetServerSessionTimeout.GetServerSessionTimeoutBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetServerSessionTimeout op = builder.Build(
                namespace_,
                podName
            );

            return ((Dsmc.Wrapper.Server)builder.WrapperObject!).GetServerSessionTimeout(op);
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