// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DslogmanagerTerminatedServers_OpExts
    {
        public static Dslogmanager.Model.ModelsListTerminatedServersResponse? Execute(
            this ListTerminatedServers.ListTerminatedServersBuilder builder,
            string namespace_
        )
        {
            ListTerminatedServers op = builder.Build(
                namespace_
            );

            return ((Dslogmanager.Wrapper.TerminatedServers)builder.WrapperObject!).ListTerminatedServers(op);
        }

        public static void Execute(
            this DownloadServerLogs.DownloadServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            DownloadServerLogs op = builder.Build(
                namespace_,
                podName
            );

            ((Dslogmanager.Wrapper.TerminatedServers)builder.WrapperObject!).DownloadServerLogs(op);
        }

        public static Dslogmanager.Model.ModelsLogFileStatus? Execute(
            this CheckServerLogs.CheckServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            CheckServerLogs op = builder.Build(
                namespace_,
                podName
            );

            return ((Dslogmanager.Wrapper.TerminatedServers)builder.WrapperObject!).CheckServerLogs(op);
        }

    }
}