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
    [SdkConsoleCommand("iam","adminupdatecountryagerestrictionv3")]
    public class AdminUpdateCountryAgeRestrictionV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminUpdateCountryAgeRestrictionV3"; } }

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelCountryAgeRestrictionV3Request Body { get; set; } = new ModelCountryAgeRestrictionV3Request();
                
        public AdminUpdateCountryAgeRestrictionV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminUpdateCountryAgeRestrictionV3 operation = new AdminUpdateCountryAgeRestrictionV3(
                CountryCode,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelCountryV3Response? response = wrapper.AdminUpdateCountryAgeRestrictionV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}