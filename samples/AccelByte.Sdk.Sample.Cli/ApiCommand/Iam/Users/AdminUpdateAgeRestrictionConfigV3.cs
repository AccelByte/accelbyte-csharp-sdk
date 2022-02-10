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
    [SdkConsoleCommand("iam","adminupdateagerestrictionconfigv3")]
    public class AdminUpdateAgeRestrictionConfigV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminUpdateAgeRestrictionConfigV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelAgeRestrictionRequestV3 Body { get; set; } = new ModelAgeRestrictionRequestV3();
                
        public AdminUpdateAgeRestrictionConfigV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminUpdateAgeRestrictionConfigV3 operation = new AdminUpdateAgeRestrictionConfigV3(
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelAgeRestrictionResponseV3? response = wrapper.AdminUpdateAgeRestrictionConfigV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}