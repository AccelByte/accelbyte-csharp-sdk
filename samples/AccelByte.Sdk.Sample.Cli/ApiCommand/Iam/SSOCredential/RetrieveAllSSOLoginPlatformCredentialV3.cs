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

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "retrieveallssologinplatformcredentialv3")]
    public class RetrieveAllSSOLoginPlatformCredentialV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "RetrieveAllSSOLoginPlatformCredentialV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public RetrieveAllSSOLoginPlatformCredentialV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RetrieveAllSSOLoginPlatformCredentialV3.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            RetrieveAllSSOLoginPlatformCredentialV3 operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Iam.Model.ModelSSOPlatformCredentialResponse>? response = wrapper.RetrieveAllSSOLoginPlatformCredentialV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}