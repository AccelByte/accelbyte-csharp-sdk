using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","exportimages")]
    public class ExportImagesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "ExportImages"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public ExportImagesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig(_SDK);

            ExportImages operation = new ExportImages(
                Namespace                
            );            
            
            List<AccelByte.Sdk.Api.Dsmc.Model.ModelsImageRecord>? response = wrapper.ExportImages(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}