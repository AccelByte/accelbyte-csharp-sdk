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
    [SdkConsoleCommand("iam","adminupdateinputvalidations")]
    public class AdminUpdateInputValidationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminUpdateInputValidations"; } }

        [SdkCommandData("body")]
        public List<ModelInputValidationUpdatePayload> Body { get; set; } = new List<ModelInputValidationUpdatePayload>();
                
        public AdminUpdateInputValidationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.InputValidations wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.InputValidations(_SDK);

            AdminUpdateInputValidations operation = new AdminUpdateInputValidations(
                Body                
            );            
            
            wrapper.AdminUpdateInputValidations(operation);
            return String.Empty;
        }
    }
}