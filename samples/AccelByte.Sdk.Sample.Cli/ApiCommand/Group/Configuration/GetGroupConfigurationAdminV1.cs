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
    [SdkConsoleCommand("group","getgroupconfigurationadminv1")]
    public class GetGroupConfigurationAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "GetGroupConfigurationAdminV1"; } }

        [SdkCommandArgument("configurationCode")]
        public string ConfigurationCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetGroupConfigurationAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Configuration(_SDK);

            GetGroupConfigurationAdminV1 operation = new GetGroupConfigurationAdminV1(
                ConfigurationCode,                
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsGetGroupConfigurationResponseV1? response = wrapper.GetGroupConfigurationAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}