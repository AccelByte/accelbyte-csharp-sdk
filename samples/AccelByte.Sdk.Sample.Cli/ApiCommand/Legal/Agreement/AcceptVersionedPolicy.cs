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
    [SdkConsoleCommand("legal","acceptversionedpolicy")]
    public class AcceptVersionedPolicyCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "AcceptVersionedPolicy"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        public AcceptVersionedPolicyCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            AcceptVersionedPolicy operation = new AcceptVersionedPolicy(
                LocalizedPolicyVersionId                
            );            
            
            wrapper.AcceptVersionedPolicy(operation);
            return String.Empty;
        }
    }
}