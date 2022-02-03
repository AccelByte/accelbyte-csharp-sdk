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
    [SdkConsoleCommand("iam","platformtokenrequesthandler")]
    public class PlatformTokenRequestHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PlatformTokenRequestHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("device_id")]
        public string DeviceId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("platform_token")]
        public string PlatformToken { get; set; } = String.Empty;
                    
        public PlatformTokenRequestHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth(_SDK);

            PlatformTokenRequestHandler operation = new PlatformTokenRequestHandler(
                Namespace,                
                PlatformId,                
                DeviceId,                
                PlatformToken                
            );            

            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponse? response = wrapper.PlatformTokenRequestHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}