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
    [SdkConsoleCommand("dsmc","updateport")]
    public class UpdatePortCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "UpdatePort"; } }

        [SdkCommandArgument("name")]
        public string Name { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdatePortRequest Body { get; set; } = new ModelsUpdatePortRequest();
                
        public UpdatePortCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Config(_SDK);

            UpdatePort operation = new UpdatePort(
                Name,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Dsmc.Model.ModelsDSMConfigRecord? response = wrapper.UpdatePort(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}