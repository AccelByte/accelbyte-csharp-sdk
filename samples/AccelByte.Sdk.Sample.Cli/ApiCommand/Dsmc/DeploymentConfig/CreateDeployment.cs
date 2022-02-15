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
    [SdkConsoleCommand("dsmc","createdeployment")]
    public class CreateDeploymentCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "CreateDeployment"; } }

        [SdkCommandArgument("deployment")]
        public string Deployment { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateDeploymentRequest Body { get; set; } = new ModelsCreateDeploymentRequest();
                
        public CreateDeploymentCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig(_SDK);

            CreateDeployment operation = new CreateDeployment(
                Deployment,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Dsmc.Model.ModelsDeploymentWithOverride? response = wrapper.CreateDeployment(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}