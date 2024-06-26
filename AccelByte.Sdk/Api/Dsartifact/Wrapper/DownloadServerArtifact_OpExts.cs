// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;
using AccelByte.Sdk.Api.Dsartifact.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsartifactDownloadServerArtifact_OpExts
    {
        public static void Execute(
            this DownloadServerArtifacts.DownloadServerArtifactsBuilder builder,
            string namespace_,
            string podName
        )
        {
            DownloadServerArtifacts op = builder.Build(
                namespace_,
                podName
            );

            ((Dsartifact.Wrapper.DownloadServerArtifact)builder.WrapperObject!).DownloadServerArtifacts(op);
        }
        public static async Task ExecuteAsync(
            this DownloadServerArtifacts.DownloadServerArtifactsBuilder builder,
            string namespace_,
            string podName
        )
        {
            DownloadServerArtifacts op = builder.Build(
                namespace_,
                podName
            );

            await ((Dsartifact.Wrapper.DownloadServerArtifact)builder.WrapperObject!).DownloadServerArtifactsAsync(op);
        }
        public static Dsartifact.Model.ModelsArtifactFileStatus? Execute(
            this CheckServerArtifact.CheckServerArtifactBuilder builder,
            string namespace_,
            string podName
        )
        {
            CheckServerArtifact op = builder.Build(
                namespace_,
                podName
            );

            return ((Dsartifact.Wrapper.DownloadServerArtifact)builder.WrapperObject!).CheckServerArtifact(op);
        }
        public static async Task<Dsartifact.Model.ModelsArtifactFileStatus?> ExecuteAsync(
            this CheckServerArtifact.CheckServerArtifactBuilder builder,
            string namespace_,
            string podName
        )
        {
            CheckServerArtifact op = builder.Build(
                namespace_,
                podName
            );

            return await ((Dsartifact.Wrapper.DownloadServerArtifact)builder.WrapperObject!).CheckServerArtifactAsync(op);
        }
    }
}