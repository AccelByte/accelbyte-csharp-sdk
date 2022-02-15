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
    [SdkConsoleCommand("platform","importstore")]
    public class ImportStoreCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "ImportStore"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandFile("file")]
        public Stream? File { get; set; }
                    
        public ImportStoreCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Store wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Store(_SDK);

            ImportStore operation = new ImportStore(
                Namespace,                
                StoreId,                
                File                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.StoreInfo? response = wrapper.ImportStore(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}