// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("iam","verify2facode")]
    public class Verify2faCodeCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "Verify2faCode"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;
                    
        [SdkCommandArgument("factor")]
        public string Factor { get; set; } = String.Empty;
                    
        [SdkCommandArgument("mfaToken")]
        public string MfaToken { get; set; } = String.Empty;
                    
        [SdkCommandArgument("rememberDevice")]
        public bool RememberDevice { get; set; } = false;
                    
        public Verify2faCodeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            Verify2faCode operation = new Verify2faCode(
                Code,                
                Factor,                
                MfaToken,                
                RememberDevice                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.Verify2faCode(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}