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
    [SdkConsoleCommand("platform","clonestore")]
    public class CloneStoreCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CloneStore"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string StoreId { get; set; } = String.Empty;

        [SdkCommandArgument("targetStoreId")]
        public string? TargetStoreId { get; set; }

        public CloneStoreCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Store wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Store(_SDK);

            CloneStore operation = new CloneStore(
                Namespace,                
                StoreId,                
                TargetStoreId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.StoreInfo? response = wrapper.CloneStore(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}