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
    [SdkConsoleCommand("iam","adminretrieveuserthirdpartyplatformtokenv3")]
    public class AdminRetrieveUserThirdPartyPlatformTokenV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminRetrieveUserThirdPartyPlatformTokenV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminRetrieveUserThirdPartyPlatformTokenV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            AdminRetrieveUserThirdPartyPlatformTokenV3 operation = new AdminRetrieveUserThirdPartyPlatformTokenV3(
                Namespace,                
                PlatformId,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenThirdPartyResponse? response = wrapper.AdminRetrieveUserThirdPartyPlatformTokenV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}