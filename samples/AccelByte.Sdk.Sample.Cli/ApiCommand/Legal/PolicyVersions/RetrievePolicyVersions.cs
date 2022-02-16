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
    [SdkConsoleCommand("legal","retrievepolicyversions")]
    public class RetrievePolicyVersionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrievePolicyVersions"; } }

        [SdkCommandArgument("basePolicyId")]
        public string? BasePolicyId { get; set; }

        [SdkCommandArgument("localeId")]
        public string? LocaleId { get; set; }

        [SdkCommandArgument("namespace_")]
        public string? Namespace { get; set; }

        public RetrievePolicyVersionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions(_SDK);

            RetrievePolicyVersions operation = new RetrievePolicyVersions(
                BasePolicyId,                
                LocaleId,                
                Namespace                
            );            
            
            List<AccelByte.Sdk.Api.Legal.Model.RetrievePolicyVersionResponse>? response = wrapper.RetrievePolicyVersions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}