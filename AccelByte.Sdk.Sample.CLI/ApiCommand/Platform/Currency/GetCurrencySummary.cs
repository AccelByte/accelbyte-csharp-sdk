using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","getcurrencysummary")]
    public class GetCurrencySummaryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetCurrencySummary"; } }

        [SdkCommandArgument("currencyCode")]
        public string CurrencyCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetCurrencySummaryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Currency wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Currency(_SDK);

            GetCurrencySummary operation = new GetCurrencySummary(
                CurrencyCode,                
                Namespace                
            );            

            AccelByte.Sdk.Api.Platform.Model.CurrencySummary? response = wrapper.GetCurrencySummary(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}