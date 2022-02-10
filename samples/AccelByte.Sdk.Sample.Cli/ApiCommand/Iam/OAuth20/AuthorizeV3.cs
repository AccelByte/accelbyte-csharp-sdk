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
    [SdkConsoleCommand("iam","authorizev3")]
    public class AuthorizeV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AuthorizeV3"; } }

        [SdkCommandArgument("codeChallenge")]
        public string? CodeChallenge { get; set; }

        [SdkCommandArgument("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        [SdkCommandArgument("redirectUri")]
        public string? RedirectUri { get; set; }

        [SdkCommandArgument("scope")]
        public string? Scope { get; set; }

        [SdkCommandArgument("state")]
        public string? State { get; set; }

        [SdkCommandArgument("targetAuthPage")]
        public string? TargetAuthPage { get; set; }

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("responseType")]
        public string ResponseType { get; set; } = String.Empty;

        public AuthorizeV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            AuthorizeV3 operation = new AuthorizeV3(
                CodeChallenge,                
                CodeChallengeMethod,                
                RedirectUri,                
                Scope,                
                State,                
                TargetAuthPage,                
                ClientId,                
                ResponseType                
            );            

            string? response = wrapper.AuthorizeV3(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}