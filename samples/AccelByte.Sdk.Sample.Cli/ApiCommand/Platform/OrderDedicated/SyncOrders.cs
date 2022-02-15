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
    [SdkConsoleCommand("platform","syncorders")]
    public class SyncOrdersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "SyncOrders"; } }

        [SdkCommandArgument("nextEvaluatedKey")]
        public string? NextEvaluatedKey { get; set; }

        [SdkCommandArgument("end")]
        public string End { get; set; } = String.Empty;

        [SdkCommandArgument("start")]
        public string Start { get; set; } = String.Empty;

        public SyncOrdersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.OrderDedicated wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.OrderDedicated(_SDK);

            SyncOrders operation = new SyncOrders(
                NextEvaluatedKey,                
                End,                
                Start                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.OrderSyncResult? response = wrapper.SyncOrders(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}