// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcPodConfig_OpExts
    {
        public static Dsmc.Model.ModelsListPodConfigResponse? Execute(
            this GetAllPodConfig.GetAllPodConfigBuilder builder,
            string namespace_
        )
        {
            GetAllPodConfig op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.PodConfig)builder.WrapperObject!).GetAllPodConfig(op);
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

    }
}