// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformOrderDedicated_OpExts
    {
        public static Platform.Model.OrderSyncResult? Execute(
            this SyncOrders.SyncOrdersBuilder builder,
            string end,
            string start
        )
        {
            SyncOrders op = builder.Build(
                end,
                start
            );

            return ((Platform.Wrapper.OrderDedicated)builder.WrapperObject!).SyncOrders(op);
        }

    }
}