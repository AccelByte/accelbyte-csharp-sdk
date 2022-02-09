using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group","deletegroupconfigurationv1")]
    public class DeleteGroupConfigurationV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "DeleteGroupConfigurationV1"; } }

        [SdkCommandArgument("configurationCode")]
        public string ConfigurationCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteGroupConfigurationV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Configuration(_SDK);

            DeleteGroupConfigurationV1 operation = new DeleteGroupConfigurationV1(
                ConfigurationCode,                
                Namespace                
            );            

            wrapper.DeleteGroupConfigurationV1(operation);
            return String.Empty;
        }
    }
}