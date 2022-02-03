using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","syncpaymentorders")]
    public class SyncPaymentOrdersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "SyncPaymentOrders"; } }

        [SdkCommandArgument("nextEvaluatedKey")]
        public string? NextEvaluatedKey { get; set; }

        [SdkCommandArgument("end")]
        public string End { get; set; }

        [SdkCommandArgument("start")]
        public string Start { get; set; }

        public SyncPaymentOrdersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentDedicated wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentDedicated(_SDK);

            SyncPaymentOrders operation = new SyncPaymentOrders(
                NextEvaluatedKey,                
                End,                
                Start                
            );            

            AccelByte.Sdk.Api.Platform.Model.PaymentOrderSyncResult? response = wrapper.SyncPaymentOrders(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}