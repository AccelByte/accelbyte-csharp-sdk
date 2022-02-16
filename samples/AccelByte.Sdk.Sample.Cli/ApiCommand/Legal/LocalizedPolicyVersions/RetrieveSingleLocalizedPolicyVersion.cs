// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","retrievesinglelocalizedpolicyversion")]
    public class RetrieveSingleLocalizedPolicyVersionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveSingleLocalizedPolicyVersion"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        public RetrieveSingleLocalizedPolicyVersionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions(_SDK);

            RetrieveSingleLocalizedPolicyVersion operation = new RetrieveSingleLocalizedPolicyVersion(
                LocalizedPolicyVersionId                
            );            
            
            AccelByte.Sdk.Api.Legal.Model.UpdateLocalizedPolicyVersionResponse? response = wrapper.RetrieveSingleLocalizedPolicyVersion(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}