using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","updatecountrygroup")]
    public class UpdateCountryGroupCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "UpdateCountryGroup"; } }

        [SdkCommandArgument("countryGroupCode")]
        public string CountryGroupCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UpdateCountryGroupRequest Body { get; set; } = new UpdateCountryGroupRequest();
                
        public UpdateCountryGroupCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Misc wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Misc(_SDK);

            UpdateCountryGroup operation = new UpdateCountryGroup(
                CountryGroupCode,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Basic.Model.CountryGroupObject? response = wrapper.UpdateCountryGroup(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}