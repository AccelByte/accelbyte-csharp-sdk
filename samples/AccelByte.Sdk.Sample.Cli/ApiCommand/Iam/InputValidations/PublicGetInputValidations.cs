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
    [SdkConsoleCommand("iam","publicgetinputvalidations")]
    public class PublicGetInputValidationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicGetInputValidations"; } }

        [SdkCommandArgument("defaultOnEmpty")]
        public bool? DefaultOnEmpty { get; set; }

        [SdkCommandArgument("languageCode")]
        public string? LanguageCode { get; set; }

        public PublicGetInputValidationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.InputValidations wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.InputValidations(_SDK);

            PublicGetInputValidations operation = new PublicGetInputValidations(
                DefaultOnEmpty,                
                LanguageCode                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelInputValidationsPublicResponse? response = wrapper.PublicGetInputValidations(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}