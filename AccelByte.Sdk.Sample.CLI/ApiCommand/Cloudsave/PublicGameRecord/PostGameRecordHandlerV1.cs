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
    [SdkConsoleCommand("cloudsave","postgamerecordhandlerv1")]
    public class PostGameRecordHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "PostGameRecordHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsGameRecordRequest? Body { get; set; }
                
        public PostGameRecordHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicGameRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicGameRecord(_SDK);

            PostGameRecordHandlerV1 operation = new PostGameRecordHandlerV1(
                Key,                
                Namespace,                
                Body                
            );            

            wrapper.PostGameRecordHandlerV1(operation);
            return String.Empty;
        }
    }
}