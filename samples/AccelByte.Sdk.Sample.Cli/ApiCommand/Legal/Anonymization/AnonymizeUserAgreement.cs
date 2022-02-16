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
    [SdkConsoleCommand("legal","anonymizeuseragreement")]
    public class AnonymizeUserAgreementCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "AnonymizeUserAgreement"; } }

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AnonymizeUserAgreementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Anonymization wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Anonymization(_SDK);

            AnonymizeUserAgreement operation = new AnonymizeUserAgreement(
                UserId                
            );            
            
            wrapper.AnonymizeUserAgreement(operation);
            return String.Empty;
        }
    }
}