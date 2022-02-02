using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","adminupdatescreenshots")]
    public class AdminUpdateScreenshotsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminUpdateScreenshots"; } }

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateScreenshotRequest? Body { get; set; }
                
        public AdminUpdateScreenshotsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent(_SDK);

            AdminUpdateScreenshots operation = new AdminUpdateScreenshots(
                ContentId,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsUpdateScreenshotResponse? response = wrapper.AdminUpdateScreenshots(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}