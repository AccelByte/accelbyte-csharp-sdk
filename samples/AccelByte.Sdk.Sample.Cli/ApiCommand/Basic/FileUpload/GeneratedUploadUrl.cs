using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","generateduploadurl")]
    public class GeneratedUploadUrlCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "GeneratedUploadUrl"; } }

        [SdkCommandArgument("folder")]
        public string Folder { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("fileType")]
        public string FileType { get; set; } = String.Empty;

        public GeneratedUploadUrlCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.FileUpload wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.FileUpload(_SDK);

            GeneratedUploadUrl operation = new GeneratedUploadUrl(
                Folder,                
                Namespace,                
                FileType                
            );            
            
            AccelByte.Sdk.Api.Basic.Model.FileUploadUrlInfo? response = wrapper.GeneratedUploadUrl(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}