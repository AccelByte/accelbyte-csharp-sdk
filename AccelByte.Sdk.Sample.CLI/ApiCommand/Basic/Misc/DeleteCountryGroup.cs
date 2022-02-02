using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","deletecountrygroup")]
    public class DeleteCountryGroupCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "DeleteCountryGroup"; } }

        [SdkCommandArgument("countryGroupCode")]
        public string CountryGroupCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteCountryGroupCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Misc wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Misc(_SDK);

            DeleteCountryGroup operation = new DeleteCountryGroup(
                CountryGroupCode,                
                Namespace                
            );            

            wrapper.DeleteCountryGroup(operation);
            return String.Empty;
        }
    }
}