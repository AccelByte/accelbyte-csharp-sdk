using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Cloudsave
{
    [SdkConsoleCommand("cloudsave","listgamerecordshandlerv1")]
    public class ListGameRecordsHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "ListGameRecordsHandlerV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("query")]
        public string? Query { get; set; }

        [SdkCommandArgument("limit")]
        public long Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long Offset { get; set; }

        public ListGameRecordsHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameRecord(_SDK);

            ListGameRecordsHandlerV1 operation = new ListGameRecordsHandlerV1(
                Namespace,                
                Query,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Cloudsave.Model.ModelsListGameRecordKeys? response = wrapper.ListGameRecordsHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}