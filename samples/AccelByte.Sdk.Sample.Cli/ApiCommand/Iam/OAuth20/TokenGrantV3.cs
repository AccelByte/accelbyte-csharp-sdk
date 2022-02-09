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
    [SdkConsoleCommand("iam","tokengrantv3")]
    public class TokenGrantV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "TokenGrantV3"; } }

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;
                    
        [SdkCommandArgument("code_verifier")]
        public string CodeVerifier { get; set; } = String.Empty;
                    
        [SdkCommandArgument("redirect_uri")]
        public string RedirectUri { get; set; } = String.Empty;
                    
        [SdkCommandArgument("refresh_token")]
        public string RefreshToken { get; set; } = String.Empty;
                    
        [SdkCommandArgument("grant_type")]
        public string GrantType { get; set; } = String.Empty;
                    
        public TokenGrantV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            TokenGrantV3 operation = new TokenGrantV3(
                ClientId,                
                Code,                
                CodeVerifier,                
                RedirectUri,                
                RefreshToken,                
                GrantType                
            );            

            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.TokenGrantV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}