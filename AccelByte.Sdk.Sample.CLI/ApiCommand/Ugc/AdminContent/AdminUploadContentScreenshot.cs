using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","adminuploadcontentscreenshot")]
    public class AdminUploadContentScreenshotCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminUploadContentScreenshot"; } }

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateScreenshotRequest? Body { get; set; }
                
        public AdminUploadContentScreenshotCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent(_SDK);

            AdminUploadContentScreenshot operation = new AdminUploadContentScreenshot(
                ContentId,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateScreenshotResponse? response = wrapper.AdminUploadContentScreenshot(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}