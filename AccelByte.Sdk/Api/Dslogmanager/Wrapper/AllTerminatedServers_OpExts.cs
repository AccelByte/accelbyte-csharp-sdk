// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DslogmanagerAllTerminatedServers_OpExts
    {
        public static void Execute(
            this BatchDownloadServerLogs.BatchDownloadServerLogsBuilder builder,
            ModelsBatchDownloadLogsRequest body
        )
        {
            BatchDownloadServerLogs op = builder.Build(
                body
            );

            ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).BatchDownloadServerLogs(op);
        }

        public static Dslogmanager.Model.ModelsListTerminatedServersResponse? Execute(
            this ListAllTerminatedServers.ListAllTerminatedServersBuilder builder
        )
        {
            ListAllTerminatedServers op = builder.Build(
            );

            return ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListAllTerminatedServers(op);
        }

    }
}