// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcDeploymentConfig_OpExts
    {
        public static Dsmc.Model.ModelsListDeploymentResponse? Execute(
            this GetAllDeployment.GetAllDeploymentBuilder builder,
            string namespace_
        )
        {
            GetAllDeployment op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).GetAllDeployment(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this GetDeployment.GetDeploymentBuilder builder,
            string deployment,
            string namespace_
        )
        {
            GetDeployment op = builder.Build(
                deployment,
                namespace_
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).GetDeployment(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this CreateDeployment.CreateDeploymentBuilder builder,
            ModelsCreateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            CreateDeployment op = builder.Build(
                body,
                deployment,
                namespace_
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).CreateDeployment(op);
        }

        public static void Execute(
            this DeleteDeployment.DeleteDeploymentBuilder builder,
            string deployment,
            string namespace_
        )
        {
            DeleteDeployment op = builder.Build(
                deployment,
                namespace_
            );

            ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).DeleteDeployment(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this UpdateDeployment.UpdateDeploymentBuilder builder,
            ModelsUpdateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            UpdateDeployment op = builder.Build(
                body,
                deployment,
                namespace_
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).UpdateDeployment(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this CreateRootRegionOverride.CreateRootRegionOverrideBuilder builder,
            ModelsCreateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region
        )
        {
            CreateRootRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).CreateRootRegionOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this DeleteRootRegionOverride.DeleteRootRegionOverrideBuilder builder,
            string deployment,
            string namespace_,
            string region
        )
        {
            DeleteRootRegionOverride op = builder.Build(
                deployment,
                namespace_,
                region
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).DeleteRootRegionOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this UpdateRootRegionOverride.UpdateRootRegionOverrideBuilder builder,
            ModelsUpdateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region
        )
        {
            UpdateRootRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).UpdateRootRegionOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this CreateDeploymentOverride.CreateDeploymentOverrideBuilder builder,
            ModelsCreateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            CreateDeploymentOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                version
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).CreateDeploymentOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this DeleteDeploymentOverride.DeleteDeploymentOverrideBuilder builder,
            string deployment,
            string namespace_,
            string version
        )
        {
            DeleteDeploymentOverride op = builder.Build(
                deployment,
                namespace_,
                version
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).DeleteDeploymentOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this UpdateDeploymentOverride.UpdateDeploymentOverrideBuilder builder,
            ModelsUpdateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            UpdateDeploymentOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                version
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).UpdateDeploymentOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this CreateOverrideRegionOverride.CreateOverrideRegionOverrideBuilder builder,
            ModelsCreateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            CreateOverrideRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region,
                version
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).CreateOverrideRegionOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this DeleteOverrideRegionOverride.DeleteOverrideRegionOverrideBuilder builder,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            DeleteOverrideRegionOverride op = builder.Build(
                deployment,
                namespace_,
                region,
                version
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).DeleteOverrideRegionOverride(op);
        }

        public static Dsmc.Model.ModelsDeploymentWithOverride? Execute(
            this UpdateOverrideRegionOverride.UpdateOverrideRegionOverrideBuilder builder,
            ModelsUpdateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            UpdateOverrideRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region,
                version
            );

            return ((Dsmc.Wrapper.DeploymentConfig)builder.WrapperObject!).UpdateOverrideRegionOverride(op);
        }

    }
}