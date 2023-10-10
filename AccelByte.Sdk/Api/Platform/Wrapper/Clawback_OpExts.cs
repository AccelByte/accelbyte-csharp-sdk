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
    public static class PlatformClawback_OpExts
    {
        public static Platform.Model.IAPClawbackPagingSlicedResult? Execute(
            this QueryIAPClawbackHistory.QueryIAPClawbackHistoryBuilder builder,
            string namespace_
        )
        {
            QueryIAPClawbackHistory op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Clawback)builder.WrapperObject!).QueryIAPClawbackHistory(op);
        }
        public static void Execute(
            this MockPlayStationStreamEvent.MockPlayStationStreamEventBuilder builder,
            string namespace_
        )
        {
            MockPlayStationStreamEvent op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.Clawback)builder.WrapperObject!).MockPlayStationStreamEvent(op);
        }
    }
}