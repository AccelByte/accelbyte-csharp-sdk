// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;
using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class Match2Operations_OpExts
    {
        public static void Execute(
            this GetHealthcheckInfo.GetHealthcheckInfoBuilder builder
        )
        {
            GetHealthcheckInfo op = builder.Build(
            );

            ((Match2.Wrapper.Operations)builder.WrapperObject!).GetHealthcheckInfo(op);
        }

        public static void Execute(
            this GetHealthcheckInfoV1.GetHealthcheckInfoV1Builder builder
        )
        {
            GetHealthcheckInfoV1 op = builder.Build(
            );

            ((Match2.Wrapper.Operations)builder.WrapperObject!).GetHealthcheckInfoV1(op);
        }

        public static void Execute(
            this VersionCheckHandler.VersionCheckHandlerBuilder builder
        )
        {
            VersionCheckHandler op = builder.Build(
            );

            ((Match2.Wrapper.Operations)builder.WrapperObject!).VersionCheckHandler(op);
        }

    }
}