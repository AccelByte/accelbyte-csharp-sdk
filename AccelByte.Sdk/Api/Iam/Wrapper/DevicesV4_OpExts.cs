// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamDevicesV4_OpExts
    {
        public static Iam.Model.ModelDevicesResponseV4? Execute(
            this AdminGetDevicesByUserV4.AdminGetDevicesByUserV4Builder builder,
            string namespace_
        )
        {
            AdminGetDevicesByUserV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetDevicesByUserV4(op);
        }
        public static Iam.Model.ModelDeviceBannedResponseV4? Execute(
            this AdminGetBannedDevicesV4.AdminGetBannedDevicesV4Builder builder,
            string namespace_
        )
        {
            AdminGetBannedDevicesV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetBannedDevicesV4(op);
        }
        public static Iam.Model.ModelDeviceBansResponseV4? Execute(
            this AdminGetUserDeviceBansV4.AdminGetUserDeviceBansV4Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserDeviceBansV4 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetUserDeviceBansV4(op);
        }
        public static void Execute(
            this AdminBanDeviceV4.AdminBanDeviceV4Builder builder,
            ModelDeviceBanRequestV4 body,
            string namespace_
        )
        {
            AdminBanDeviceV4 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminBanDeviceV4(op);
        }
        public static Iam.Model.ModelDeviceBanResponseV4? Execute(
            this AdminGetDeviceBanV4.AdminGetDeviceBanV4Builder builder,
            string banId,
            string namespace_
        )
        {
            AdminGetDeviceBanV4 op = builder.Build(
                banId,
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetDeviceBanV4(op);
        }
        public static void Execute(
            this AdminUpdateDeviceBanV4.AdminUpdateDeviceBanV4Builder builder,
            ModelDeviceBanUpdateRequestV4 body,
            string banId,
            string namespace_
        )
        {
            AdminUpdateDeviceBanV4 op = builder.Build(
                body,
                banId,
                namespace_
            );

            ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminUpdateDeviceBanV4(op);
        }
        public static void Execute(
            this AdminGenerateReportV4.AdminGenerateReportV4Builder builder,
            string namespace_,
            string deviceType
        )
        {
            AdminGenerateReportV4 op = builder.Build(
                namespace_,
                deviceType
            );

            ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGenerateReportV4(op);
        }
        public static Iam.Model.ModelDeviceTypesResponseV4? Execute(
            this AdminGetDeviceTypesV4.AdminGetDeviceTypesV4Builder builder,
            string namespace_
        )
        {
            AdminGetDeviceTypesV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetDeviceTypesV4(op);
        }
        public static Iam.Model.ModelDeviceBansResponseV4? Execute(
            this AdminGetDeviceBansV4.AdminGetDeviceBansV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            AdminGetDeviceBansV4 op = builder.Build(
                deviceId,
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetDeviceBansV4(op);
        }
        public static Iam.Model.ModelDeviceIDDecryptResponseV4? Execute(
            this AdminDecryptDeviceV4.AdminDecryptDeviceV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            AdminDecryptDeviceV4 op = builder.Build(
                deviceId,
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminDecryptDeviceV4(op);
        }
        public static void Execute(
            this AdminUnbanDeviceV4.AdminUnbanDeviceV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            AdminUnbanDeviceV4 op = builder.Build(
                deviceId,
                namespace_
            );

            ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminUnbanDeviceV4(op);
        }
        public static Iam.Model.ModelDeviceUsersResponseV4? Execute(
            this AdminGetUsersByDeviceV4.AdminGetUsersByDeviceV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            AdminGetUsersByDeviceV4 op = builder.Build(
                deviceId,
                namespace_
            );

            return ((Iam.Wrapper.DevicesV4)builder.WrapperObject!).AdminGetUsersByDeviceV4(op);
        }
    }
}