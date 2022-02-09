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
    [SdkConsoleCommand("ugc","downloadcontentbysharecode")]
    public class DownloadContentByShareCodeCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "DownloadContentByShareCode"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("shareCode")]
        public string ShareCode { get; set; } = String.Empty;

        public DownloadContentByShareCodeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicContent(_SDK);

            DownloadContentByShareCode operation = new DownloadContentByShareCode(
                Namespace,                
                ShareCode                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsContentDownloadResponse? response = wrapper.DownloadContentByShareCode(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}