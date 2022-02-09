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
    [SdkConsoleCommand("iam","tokengrant")]
    public class TokenGrantCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "TokenGrant"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;
                    
        [SdkCommandArgument("extend_exp")]
        public bool ExtendExp { get; set; } = false;
                    
        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;
                    
        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        [SdkCommandArgument("redirect_uri")]
        public string RedirectUri { get; set; } = String.Empty;
                    
        [SdkCommandArgument("refresh_token")]
        public string RefreshToken { get; set; } = String.Empty;
                    
        [SdkCommandArgument("username")]
        public string Username { get; set; } = String.Empty;
                    
        [SdkCommandArgument("grant_type")]
        public string GrantType { get; set; } = String.Empty;
                    
        public TokenGrantCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth(_SDK);

            TokenGrant operation = new TokenGrant(
                Code,                
                ExtendExp,                
                Namespace,                
                Password,                
                RedirectUri,                
                RefreshToken,                
                Username,                
                GrantType                
            );            

            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponse? response = wrapper.TokenGrant(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}