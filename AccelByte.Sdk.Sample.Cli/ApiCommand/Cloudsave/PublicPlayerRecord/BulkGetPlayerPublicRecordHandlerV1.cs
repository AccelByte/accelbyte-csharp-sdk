using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Cloudsave
{
    [SdkConsoleCommand("cloudsave","bulkgetplayerpublicrecordhandlerv1")]
    public class BulkGetPlayerPublicRecordHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "BulkGetPlayerPublicRecordHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkUserIDsRequest? Body { get; set; }
                
        public BulkGetPlayerPublicRecordHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerRecord(_SDK);

            BulkGetPlayerPublicRecordHandlerV1 operation = new BulkGetPlayerPublicRecordHandlerV1(
                Key,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkGetPlayerRecordResponse? response = wrapper.BulkGetPlayerPublicRecordHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}