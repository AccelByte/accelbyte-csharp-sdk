// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcAdmin_OpExts
    {
        public static Dsmc.Model.ModelsListServerResponse? Execute(
            this ListServer.ListServerBuilder builder,
            string namespace_
        )
        {
            ListServer op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).ListServer(op);
        }

        public static Dsmc.Model.ModelsCountServerResponse? Execute(
            this CountServer.CountServerBuilder builder,
            string namespace_
        )
        {
            CountServer op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).CountServer(op);
        }

        public static Dsmc.Model.ModelsDetailedCountServerResponse? Execute(
            this CountServerDetailed.CountServerDetailedBuilder builder,
            string namespace_
        )
        {
            CountServerDetailed op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).CountServerDetailed(op);
        }

        public static Dsmc.Model.ModelsListServerResponse? Execute(
            this ListLocalServer.ListLocalServerBuilder builder,
            string namespace_
        )
        {
            ListLocalServer op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).ListLocalServer(op);
        }

        public static void Execute(
            this DeleteLocalServer.DeleteLocalServerBuilder builder,
            string name,
            string namespace_
        )
        {
            DeleteLocalServer op = builder.Build(
                name,
                namespace_
            );

            ((Dsmc.Wrapper.Admin)builder.WrapperObject!).DeleteLocalServer(op);
        }

        public static Dsmc.Model.ModelsServer? Execute(
            this GetServer.GetServerBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetServer op = builder.Build(
                namespace_,
                podName
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).GetServer(op);
        }

        public static void Execute(
            this DeleteServer.DeleteServerBuilder builder,
            string namespace_,
            string podName
        )
        {
            DeleteServer op = builder.Build(
                namespace_,
                podName
            );

            ((Dsmc.Wrapper.Admin)builder.WrapperObject!).DeleteServer(op);
        }

        public static Dsmc.Model.ModelsServerLogs? Execute(
            this GetServerLogs.GetServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetServerLogs op = builder.Build(
                namespace_,
                podName
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).GetServerLogs(op);
        }

        public static Dsmc.Model.ModelsListSessionResponse? Execute(
            this ListSession.ListSessionBuilder builder,
            string namespace_
        )
        {
            ListSession op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).ListSession(op);
        }

        public static Dsmc.Model.ModelsCountSessionResponse? Execute(
            this CountSession.CountSessionBuilder builder,
            string namespace_
        )
        {
            CountSession op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Admin)builder.WrapperObject!).CountSession(op);
        }

        public static void Execute(
            this DeleteSession.DeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            DeleteSession op = builder.Build(
                namespace_,
                sessionID
            );

            ((Dsmc.Wrapper.Admin)builder.WrapperObject!).DeleteSession(op);
        }

    }
}