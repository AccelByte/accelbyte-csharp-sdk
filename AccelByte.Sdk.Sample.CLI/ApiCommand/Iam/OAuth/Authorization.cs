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
    [SdkConsoleCommand("iam","authorization")]
    public class AuthorizationCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "Authorization"; } }

        [SdkCommandArgument("login")]
        public string Login { get; set; } = String.Empty;
                    
        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        [SdkCommandArgument("scope")]
        public string Scope { get; set; } = String.Empty;
                    
        [SdkCommandArgument("state")]
        public string State { get; set; } = String.Empty;
                    
        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("redirect_uri")]
        public string RedirectUri { get; set; } = String.Empty;
                    
        [SdkCommandArgument("response_type")]
        public string ResponseType { get; set; } = String.Empty;
                    
        public AuthorizationCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth(_SDK);

            Authorization operation = new Authorization(
                Login,                
                Password,                
                Scope,                
                State,                
                ClientId,                
                RedirectUri,                
                ResponseType                
            );            

            string? response = wrapper.Authorization(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}