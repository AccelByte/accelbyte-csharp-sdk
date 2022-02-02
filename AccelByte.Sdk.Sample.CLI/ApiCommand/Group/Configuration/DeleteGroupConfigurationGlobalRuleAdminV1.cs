using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Group
{
    [SdkConsoleCommand("group","deletegroupconfigurationglobalruleadminv1")]
    public class DeleteGroupConfigurationGlobalRuleAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "DeleteGroupConfigurationGlobalRuleAdminV1"; } }

        [SdkCommandArgument("allowedAction")]
        public string AllowedAction { get; set; } = String.Empty;

        [SdkCommandArgument("configurationCode")]
        public string ConfigurationCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteGroupConfigurationGlobalRuleAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Configuration(_SDK);

            DeleteGroupConfigurationGlobalRuleAdminV1 operation = new DeleteGroupConfigurationGlobalRuleAdminV1(
                AllowedAction,                
                ConfigurationCode,                
                Namespace                
            );            

            AccelByte.Sdk.Api.Group.Model.ModelsUpdateGroupConfigurationResponseV1? response = wrapper.DeleteGroupConfigurationGlobalRuleAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}