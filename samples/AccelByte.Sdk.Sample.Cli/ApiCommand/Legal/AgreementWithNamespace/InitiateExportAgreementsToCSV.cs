// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal", "initiateexportagreementstocsv")]
    public class InitiateExportAgreementsToCSVCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "InitiateExportAgreementsToCSV"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        public InitiateExportAgreementsToCSVCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.AgreementWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.AgreementWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.InitiateExportAgreementsToCSV.Builder;





            InitiateExportAgreementsToCSV operation = opBuilder.Build(
                Namespace,
                PolicyVersionId
            );


            AccelByte.Sdk.Api.Legal.Model.InitiateExportAgreementsToCSVResponse? response = wrapper.InitiateExportAgreementsToCSV(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}