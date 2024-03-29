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
    public static class BasicEQU8Config_OpExts
    {
        public static Basic.Model.Equ8Config? Execute(
            this GetConfig.GetConfigBuilder builder,
            string namespace_
        )
        {
            GetConfig op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.EQU8Config)builder.WrapperObject!).GetConfig(op);
        }
        public static void Execute(
            this DeleteConfig.DeleteConfigBuilder builder,
            string namespace_
        )
        {
            DeleteConfig op = builder.Build(
                namespace_
            );

            ((Basic.Wrapper.EQU8Config)builder.WrapperObject!).DeleteConfig(op);
        }
        public static Basic.Model.Equ8Config? Execute(
            this UpdateConfig.UpdateConfigBuilder builder,
            string namespace_
        )
        {
            UpdateConfig op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.EQU8Config)builder.WrapperObject!).UpdateConfig(op);
        }
    }
}