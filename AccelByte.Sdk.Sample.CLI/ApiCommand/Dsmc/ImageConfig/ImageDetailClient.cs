using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","imagedetailclient")]
    public class ImageDetailClientCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "ImageDetailClient"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("version")]
        public string Version { get; set; } = String.Empty;

        public ImageDetailClientCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig(_SDK);

            ImageDetailClient operation = new ImageDetailClient(
                Namespace,                
                Version                
            );            

            AccelByte.Sdk.Api.Dsmc.Model.ModelsGetImageDetailResponse? response = wrapper.ImageDetailClient(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}