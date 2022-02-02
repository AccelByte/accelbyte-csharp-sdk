using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","changepreferenceconsent")]
    public class ChangePreferenceConsentCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "ChangePreferenceConsent"; } }

        [SdkCommandData("body")]
        public List<AcceptAgreementRequest>? Body { get; set; }
                
        public ChangePreferenceConsentCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            ChangePreferenceConsent operation = new ChangePreferenceConsent(
                Body                
            );            

            wrapper.ChangePreferenceConsent(operation);
            return String.Empty;
        }
    }
}