using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","admingetinputvalidations")]
    public class AdminGetInputValidationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetInputValidations"; } }

        public AdminGetInputValidationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.InputValidations wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.InputValidations(_SDK);

            AdminGetInputValidations operation = new AdminGetInputValidations(
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelInputValidationsResponse? response = wrapper.AdminGetInputValidations(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}