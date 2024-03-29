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
        public static Platform.Model.LootBoxPluginConfigInfo? Execute(
            this GetLootBoxPluginConfig.GetLootBoxPluginConfigBuilder builder,
            string namespace_
        )
        {
            GetLootBoxPluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).GetLootBoxPluginConfig(op);
        }
        public static Platform.Model.LootBoxPluginConfigInfo? Execute(
            this UpdateLootBoxPluginConfig.UpdateLootBoxPluginConfigBuilder builder,
            string namespace_
        )
        {
            UpdateLootBoxPluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UpdateLootBoxPluginConfig(op);
        }
        public static void Execute(
            this DeleteLootBoxPluginConfig.DeleteLootBoxPluginConfigBuilder builder,
            string namespace_
        )
        {
            DeleteLootBoxPluginConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).DeleteLootBoxPluginConfig(op);
        }
        public static Platform.Model.LootBoxPluginConfigInfo? Execute(
            this UplodLootBoxPluginConfigCert.UplodLootBoxPluginConfigCertBuilder builder,
            string namespace_
        )
        {
            UplodLootBoxPluginConfigCert op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UplodLootBoxPluginConfigCert(op);
        }
        public static Platform.Model.GrpcServerInfo? Execute(
            this GetLootBoxGrpcInfo.GetLootBoxGrpcInfoBuilder builder,
            string namespace_
        )
        {
            GetLootBoxGrpcInfo op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).GetLootBoxGrpcInfo(op);
        }
        public static Platform.Model.SectionPluginConfigInfo? Execute(
            this GetSectionPluginConfig.GetSectionPluginConfigBuilder builder,
            string namespace_
        )
        {
            GetSectionPluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).GetSectionPluginConfig(op);
        }
        public static Platform.Model.SectionPluginConfigInfo? Execute(
            this UpdateSectionPluginConfig.UpdateSectionPluginConfigBuilder builder,
            string namespace_
        )
        {
            UpdateSectionPluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UpdateSectionPluginConfig(op);
        }
        public static void Execute(
            this DeleteSectionPluginConfig.DeleteSectionPluginConfigBuilder builder,
            string namespace_
        )
        {
            DeleteSectionPluginConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).DeleteSectionPluginConfig(op);
        }
        public static Platform.Model.SectionPluginConfigInfo? Execute(
            this UploadSectionPluginConfigCert.UploadSectionPluginConfigCertBuilder builder,
            string namespace_
        )
        {
            UploadSectionPluginConfigCert op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UploadSectionPluginConfigCert(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
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
        public static Platform.Model.RevocationPluginConfigInfo? Execute(
            this GetRevocationPluginConfig.GetRevocationPluginConfigBuilder builder,
            string namespace_
        )
        {
            GetRevocationPluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).GetRevocationPluginConfig(op);
        }
        public static Platform.Model.RevocationPluginConfigInfo? Execute(
            this UpdateRevocationPluginConfig.UpdateRevocationPluginConfigBuilder builder,
            string namespace_
        )
        {
            UpdateRevocationPluginConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UpdateRevocationPluginConfig(op);
        }
        public static void Execute(
            this DeleteRevocationPluginConfig.DeleteRevocationPluginConfigBuilder builder,
            string namespace_
        )
        {
            DeleteRevocationPluginConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).DeleteRevocationPluginConfig(op);
        }
        public static Platform.Model.RevocationPluginConfigInfo? Execute(
            this UploadRevocationPluginConfigCert.UploadRevocationPluginConfigCertBuilder builder,
            string namespace_
        )
        {
            UploadRevocationPluginConfigCert op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.ServicePluginConfig)builder.WrapperObject!).UploadRevocationPluginConfigCert(op);
        }
    }
}