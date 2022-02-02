using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","publicgenerateduseruploadcontenturl")]
    public class PublicGeneratedUserUploadContentUrlCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "PublicGeneratedUserUploadContentUrl"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("fileType")]
        public string FileType { get; set; }

        public PublicGeneratedUserUploadContentUrlCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.FileUpload wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.FileUpload(_SDK);

            PublicGeneratedUserUploadContentUrl operation = new PublicGeneratedUserUploadContentUrl(
                Namespace,                
                UserId,                
                FileType                
            );            

            AccelByte.Sdk.Api.Basic.Model.FileUploadUrlInfo? response = wrapper.PublicGeneratedUserUploadContentUrl(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}