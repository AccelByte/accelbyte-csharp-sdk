// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcPodConfig_OpExts
    {
        public static Dsmc.Model.ModelsInstanceSpec? Execute(
            this GetLowestInstanceSpec.GetLowestInstanceSpecBuilder builder
        )
        {
            GetLowestInstanceSpec op = builder.Build(
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetLowestInstanceSpec(op);
        }
        public static async Task<Dsmc.Model.ModelsInstanceSpec?> ExecuteAsync(
            this GetLowestInstanceSpec.GetLowestInstanceSpecBuilder builder
        )
        {
            GetLowestInstanceSpec op = builder.Build(
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetLowestInstanceSpecAsync(op);
        }
        public static Dsmc.Model.ModelsListPodConfigResponse? Execute(
            this GetAllPodConfig.GetAllPodConfigBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            GetAllPodConfig op = builder.Build(
                namespace_,
                count,
                offset
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetAllPodConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsListPodConfigResponse?> ExecuteAsync(
            this GetAllPodConfig.GetAllPodConfigBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            GetAllPodConfig op = builder.Build(
                namespace_,
                count,
                offset
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetAllPodConfigAsync(op);
        }
        public static Dsmc.Model.ModelsPodConfigRecord? Execute(
            this GetPodConfig.GetPodConfigBuilder builder,
            string name,
            string namespace_
        )
        {
            GetPodConfig op = builder.Build(
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetPodConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsPodConfigRecord?> ExecuteAsync(
            this GetPodConfig.GetPodConfigBuilder builder,
            string name,
            string namespace_
        )
        {
            GetPodConfig op = builder.Build(
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetPodConfigAsync(op);
        }
        public static Dsmc.Model.ModelsPodConfigRecord? Execute(
            this CreatePodConfig.CreatePodConfigBuilder builder,
            ModelsCreatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            CreatePodConfig op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).CreatePodConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsPodConfigRecord?> ExecuteAsync(
            this CreatePodConfig.CreatePodConfigBuilder builder,
            ModelsCreatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            CreatePodConfig op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).CreatePodConfigAsync(op);
        }
        public static void Execute(
            this DeletePodConfig.DeletePodConfigBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePodConfig op = builder.Build(
                name,
                namespace_
            );

            ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).DeletePodConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeletePodConfig.DeletePodConfigBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePodConfig op = builder.Build(
                name,
                namespace_
            );

            await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).DeletePodConfigAsync(op);
        }
        public static Dsmc.Model.ModelsPodConfigRecord? Execute(
            this UpdatePodConfig.UpdatePodConfigBuilder builder,
            ModelsUpdatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            UpdatePodConfig op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).UpdatePodConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsPodConfigRecord?> ExecuteAsync(
            this UpdatePodConfig.UpdatePodConfigBuilder builder,
            ModelsUpdatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            UpdatePodConfig op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).UpdatePodConfigAsync(op);
        }
        public static Dsmc.Model.ModelsListPodConfigResponse? Execute(
            this GetAllPodConfigClient.GetAllPodConfigClientBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            GetAllPodConfigClient op = builder.Build(
                namespace_,
                count,
                offset
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetAllPodConfigClient(op);
        }
        public static async Task<Dsmc.Model.ModelsListPodConfigResponse?> ExecuteAsync(
            this GetAllPodConfigClient.GetAllPodConfigClientBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            GetAllPodConfigClient op = builder.Build(
                namespace_,
                count,
                offset
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetAllPodConfigClientAsync(op);
        }
        public static Dsmc.Model.ModelsPodConfigRecord? Execute(
            this CreatePodConfigClient.CreatePodConfigClientBuilder builder,
            ModelsCreatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            CreatePodConfigClient op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).CreatePodConfigClient(op);
        }
        public static async Task<Dsmc.Model.ModelsPodConfigRecord?> ExecuteAsync(
            this CreatePodConfigClient.CreatePodConfigClientBuilder builder,
            ModelsCreatePodConfigRequest body,
            string name,
            string namespace_
        )
        {
            CreatePodConfigClient op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).CreatePodConfigClientAsync(op);
        }
        public static void Execute(
            this DeletePodConfigClient.DeletePodConfigClientBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePodConfigClient op = builder.Build(
                name,
                namespace_
            );

            ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).DeletePodConfigClient(op);
        }
        public static async Task ExecuteAsync(
            this DeletePodConfigClient.DeletePodConfigClientBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePodConfigClient op = builder.Build(
                name,
                namespace_
            );

            await ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).DeletePodConfigClientAsync(op);
        }
    }
}