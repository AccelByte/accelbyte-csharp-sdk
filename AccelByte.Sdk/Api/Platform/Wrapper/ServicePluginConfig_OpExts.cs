// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformServicePluginConfig_OpExts
    {
        public static Platform.Model.ServicePluginConfigInfo? Execute(
            this GetServicePluginConfig.GetServicePluginConfigBuilder builder,
            string namespace_
        )
        {
            GetServicePluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).GetServicePluginConfig(op);
        }

        public static Platform.Model.ServicePluginConfigInfo? Execute(
            this UpdateServicePluginConfig.UpdateServicePluginConfigBuilder builder,
            string namespace_
        )
        {
            UpdateServicePluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UpdateServicePluginConfig(op);
        }

        public static void Execute(
            this DeleteServicePluginConfig.DeleteServicePluginConfigBuilder builder,
            string namespace_
        )
        {
            DeleteServicePluginConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).DeleteServicePluginConfig(op);
        }

    }
}