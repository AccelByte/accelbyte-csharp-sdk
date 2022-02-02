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
    [SdkConsoleCommand("cloudsave","adminpostplayerpublicrecordhandlerv1")]
    public class AdminPostPlayerPublicRecordHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "AdminPostPlayerPublicRecordHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsPlayerRecordRequest? Body { get; set; }
                
        public AdminPostPlayerPublicRecordHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord(_SDK);

            AdminPostPlayerPublicRecordHandlerV1 operation = new AdminPostPlayerPublicRecordHandlerV1(
                Key,                
                Namespace,                
                UserId,                
                Body                
            );            

            wrapper.AdminPostPlayerPublicRecordHandlerV1(operation);
            return String.Empty;
        }
    }
}