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
    [SdkConsoleCommand("iam","adminupdateagerestrictionconfigv2")]
    public class AdminUpdateAgeRestrictionConfigV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminUpdateAgeRestrictionConfigV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelAgeRestrictionRequest Body { get; set; } = new ModelAgeRestrictionRequest();
                
        public AdminUpdateAgeRestrictionConfigV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminUpdateAgeRestrictionConfigV2 operation = new AdminUpdateAgeRestrictionConfigV2(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelAgeRestrictionResponse? response = wrapper.AdminUpdateAgeRestrictionConfigV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}