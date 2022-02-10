using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","updateadminemailconfiguration")]
    public class UpdateAdminEmailConfigurationCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "UpdateAdminEmailConfiguration"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<string> Body { get; set; } = new List<string>();
                
        public UpdateAdminEmailConfigurationCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval(_SDK);

            UpdateAdminEmailConfiguration operation = new UpdateAdminEmailConfiguration(
                Namespace,                
                Body                
            );            

            wrapper.UpdateAdminEmailConfiguration(operation);
            return String.Empty;
        }
    }
}