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
    [SdkConsoleCommand("cloudsave","getplayerrecordhandlerv1")]
    public class GetPlayerRecordHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "GetPlayerRecordHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public GetPlayerRecordHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerRecord(_SDK);

            GetPlayerRecordHandlerV1 operation = new GetPlayerRecordHandlerV1(
                Key,                
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Cloudsave.Model.ModelsPlayerRecord? response = wrapper.GetPlayerRecordHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}