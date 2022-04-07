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
    [SdkConsoleCommand("legal","changepreferenceconsent1")]
    public class ChangePreferenceConsent1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "ChangePreferenceConsent1"; } }

        [SdkCommandData("body")]
        public List<AcceptAgreementRequest> Body { get; set; } = new List<AcceptAgreementRequest>();
                
        public ChangePreferenceConsent1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            ChangePreferenceConsent1 operation = new ChangePreferenceConsent1(
                Body                
            );            
            
            wrapper.ChangePreferenceConsent1(operation);
            return String.Empty;
        }
    }
}