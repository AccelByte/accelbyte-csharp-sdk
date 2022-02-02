using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","platformtokengrantv3")]
    public class PlatformTokenGrantV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PlatformTokenGrantV3"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("device_id")]
        public string DeviceId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("platform_token")]
        public string PlatformToken { get; set; } = String.Empty;
                    
        public PlatformTokenGrantV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            PlatformTokenGrantV3 operation = new PlatformTokenGrantV3(
                PlatformId,                
                ClientId,                
                DeviceId,                
                PlatformToken                
            );            

            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponse? response = wrapper.PlatformTokenGrantV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}