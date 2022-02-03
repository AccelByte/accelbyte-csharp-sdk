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
    [SdkConsoleCommand("cloudsave","putplayerpublicrecordconcurrenthandlerv1")]
    public class PutPlayerPublicRecordConcurrentHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "PutPlayerPublicRecordConcurrentHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsConcurrentRecordRequest? Body { get; set; }
                
        public PutPlayerPublicRecordConcurrentHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.ConcurrentRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.ConcurrentRecord(_SDK);

            PutPlayerPublicRecordConcurrentHandlerV1 operation = new PutPlayerPublicRecordConcurrentHandlerV1(
                Key,                
                Namespace,                
                UserId,                
                Body                
            );            

            wrapper.PutPlayerPublicRecordConcurrentHandlerV1(operation);
            return String.Empty;
        }
    }
}