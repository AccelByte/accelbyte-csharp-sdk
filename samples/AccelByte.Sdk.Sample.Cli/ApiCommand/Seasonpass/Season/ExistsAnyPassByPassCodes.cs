using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","existsanypassbypasscodes")]
    public class ExistsAnyPassByPassCodesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "ExistsAnyPassByPassCodes"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("passCodes")]
        public List<string>? PassCodes { get; set; }

        public ExistsAnyPassByPassCodesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            ExistsAnyPassByPassCodes operation = new ExistsAnyPassByPassCodes(
                Namespace,                
                UserId,                
                PassCodes                
            );            
            
            AccelByte.Sdk.Api.Seasonpass.Model.Ownership? response = wrapper.ExistsAnyPassByPassCodes(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}