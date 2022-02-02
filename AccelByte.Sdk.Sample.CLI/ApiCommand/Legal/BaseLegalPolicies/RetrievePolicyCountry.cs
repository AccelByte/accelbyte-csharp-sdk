using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","retrievepolicycountry")]
    public class RetrievePolicyCountryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrievePolicyCountry"; } }

        [SdkCommandArgument("basePolicyId")]
        public string BasePolicyId { get; set; } = String.Empty;

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; } = String.Empty;

        public RetrievePolicyCountryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies(_SDK);

            RetrievePolicyCountry operation = new RetrievePolicyCountry(
                BasePolicyId,                
                CountryCode                
            );            

            AccelByte.Sdk.Api.Legal.Model.RetrievePolicyResponse? response = wrapper.RetrievePolicyCountry(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}