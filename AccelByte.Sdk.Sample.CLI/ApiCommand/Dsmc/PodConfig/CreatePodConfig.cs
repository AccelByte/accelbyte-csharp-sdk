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
    [SdkConsoleCommand("dsmc","createpodconfig")]
    public class CreatePodConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "CreatePodConfig"; } }

        [SdkCommandArgument("name")]
        public string Name { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreatePodConfigRequest? Body { get; set; }
                
        public CreatePodConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.PodConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.PodConfig(_SDK);

            CreatePodConfig operation = new CreatePodConfig(
                Name,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Dsmc.Model.ModelsPodConfigRecord? response = wrapper.CreatePodConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}