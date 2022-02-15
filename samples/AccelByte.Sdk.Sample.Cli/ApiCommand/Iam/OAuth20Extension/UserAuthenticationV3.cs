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
    [SdkConsoleCommand("iam","userauthenticationv3")]
    public class UserAuthenticationV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "UserAuthenticationV3"; } }

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("extend_exp")]
        public bool ExtendExp { get; set; } = false;
                    
        [SdkCommandArgument("redirect_uri")]
        public string RedirectUri { get; set; } = String.Empty;
                    
        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        [SdkCommandArgument("request_id")]
        public string RequestId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("user_name")]
        public string UserName { get; set; } = String.Empty;
                    
        public UserAuthenticationV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            UserAuthenticationV3 operation = new UserAuthenticationV3(
                ClientId,                
                ExtendExp,                
                RedirectUri,                
                Password,                
                RequestId,                
                UserName                
            );            
            
            string? response = wrapper.UserAuthenticationV3(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}