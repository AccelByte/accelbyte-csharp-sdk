using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","getcurrencyconfig")]
    public class GetCurrencyConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetCurrencyConfig"; } }

        [SdkCommandArgument("currencyCode")]
        public string CurrencyCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetCurrencyConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Currency wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Currency(_SDK);

            GetCurrencyConfig operation = new GetCurrencyConfig(
                CurrencyCode,                
                Namespace                
            );            

            AccelByte.Sdk.Api.Platform.Model.CurrencyConfig? response = wrapper.GetCurrencyConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}