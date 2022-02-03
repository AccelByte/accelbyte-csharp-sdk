using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","adminresetinputvalidations")]
    public class AdminResetInputValidationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminResetInputValidations"; } }

        [SdkCommandArgument("field")]
        public string Field { get; set; } = String.Empty;

        public AdminResetInputValidationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.InputValidations wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.InputValidations(_SDK);

            AdminResetInputValidations operation = new AdminResetInputValidations(
                Field                
            );            

            wrapper.AdminResetInputValidations(operation);
            return String.Empty;
        }
    }
}