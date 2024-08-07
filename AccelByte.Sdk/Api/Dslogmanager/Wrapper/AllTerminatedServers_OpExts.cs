// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DslogmanagerAllTerminatedServers_OpExts
    {
        public static Stream? Execute(
            this BatchDownloadServerLogs.BatchDownloadServerLogsBuilder builder,
            ModelsBatchDownloadLogsRequest body
        )
        {
            BatchDownloadServerLogs op = builder.Build(
                body
            );

            return ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).BatchDownloadServerLogs(op);
        }
        public static async Task<Stream?> ExecuteAsync(
            this BatchDownloadServerLogs.BatchDownloadServerLogsBuilder builder,
            ModelsBatchDownloadLogsRequest body
        )
        {
            BatchDownloadServerLogs op = builder.Build(
                body
            );

            return await ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).BatchDownloadServerLogsAsync(op);
        }
        public static Dslogmanager.Model.ModelsListTerminatedServersResponse? Execute(
            this ListMetadataServers.ListMetadataServersBuilder builder,
            ModelsMetadataServersRequest body
        )
        {
            ListMetadataServers op = builder.Build(
                body
            );

            return ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListMetadataServers(op);
        }
        public static async Task<Dslogmanager.Model.ModelsListTerminatedServersResponse?> ExecuteAsync(
            this ListMetadataServers.ListMetadataServersBuilder builder,
            ModelsMetadataServersRequest body
        )
        {
            ListMetadataServers op = builder.Build(
                body
            );

            return await ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListMetadataServersAsync(op);
        }
        public static Dslogmanager.Model.ModelsListTerminatedServersResponse? Execute(
            this ListAllTerminatedServers.ListAllTerminatedServersBuilder builder
        )
        {
            ListAllTerminatedServers op = builder.Build(
            );

            return ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListAllTerminatedServers(op);
        }
        public static async Task<Dslogmanager.Model.ModelsListTerminatedServersResponse?> ExecuteAsync(
            this ListAllTerminatedServers.ListAllTerminatedServersBuilder builder
        )
        {
            ListAllTerminatedServers op = builder.Build(
            );

            return await ((Dslogmanager.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListAllTerminatedServersAsync(op);
        }
    }
}