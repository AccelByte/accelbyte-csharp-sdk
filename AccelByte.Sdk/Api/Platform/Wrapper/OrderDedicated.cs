// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class OrderDedicated
    {
        private readonly AccelByteSDK _sdk;

        public OrderDedicated(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SyncOrders.SyncOrdersBuilder SyncOrdersOp
        {
            get { return Operation.SyncOrders.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.OrderSyncResult? SyncOrders(SyncOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class OrderDedicated_OperationExtensions
    {
        public static Model.OrderSyncResult? Execute(
            this SyncOrders.SyncOrdersBuilder builder,
            string end,
            string start
        )
        {
            SyncOrders op = builder.Build(
                end,
                start
            );

            return ((OrderDedicated)builder.WrapperObject!).SyncOrders(op);
        }

    }
}