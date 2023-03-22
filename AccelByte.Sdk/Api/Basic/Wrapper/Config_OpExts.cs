// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicConfig_OpExts
    {
        public static Basic.Model.ConfigInfo? Execute(
            this CreateConfig.CreateConfigBuilder builder,
            string namespace_
        )
        {
            CreateConfig op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Config)builder.WrapperObject!).CreateConfig(op);
        }
        public static Basic.Model.ConfigInfo? Execute(
            this GetConfig1.GetConfig1Builder builder,
            string configKey,
            string namespace_
        )
        {
            GetConfig1 op = builder.Build(
                configKey,
                namespace_
            );

            return ((Basic.Wrapper.Config)builder.WrapperObject!).GetConfig1(op);
        }
        public static void Execute(
            this DeleteConfig1.DeleteConfig1Builder builder,
            string configKey,
            string namespace_
        )
        {
            DeleteConfig1 op = builder.Build(
                configKey,
                namespace_
            );

            ((Basic.Wrapper.Config)builder.WrapperObject!).DeleteConfig1(op);
        }
        public static Basic.Model.ConfigInfo? Execute(
            this UpdateConfig1.UpdateConfig1Builder builder,
            string configKey,
            string namespace_
        )
        {
            UpdateConfig1 op = builder.Build(
                configKey,
                namespace_
            );

            return ((Basic.Wrapper.Config)builder.WrapperObject!).UpdateConfig1(op);
        }
        public static Basic.Model.ConfigInfo? Execute(
            this GetPublisherConfig.GetPublisherConfigBuilder builder,
            string configKey,
            string namespace_
        )
        {
            GetPublisherConfig op = builder.Build(
                configKey,
                namespace_
            );

            return ((Basic.Wrapper.Config)builder.WrapperObject!).GetPublisherConfig(op);
        }
    }
}