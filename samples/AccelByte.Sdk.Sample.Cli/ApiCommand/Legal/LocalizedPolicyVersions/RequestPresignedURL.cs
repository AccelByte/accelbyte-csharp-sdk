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
    [SdkConsoleCommand("legal", "requestpresignedurl")]
    public class RequestPresignedURLCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RequestPresignedURL"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UploadPolicyVersionAttachmentRequest Body { get; set; } = new UploadPolicyVersionAttachmentRequest();

        public RequestPresignedURLCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RequestPresignedURL.Builder;


            if (Body != null)
                opBuilder.SetBody((UploadPolicyVersionAttachmentRequest)Body);



            RequestPresignedURL operation = opBuilder.Build(
                LocalizedPolicyVersionId
            );


            AccelByte.Sdk.Api.Legal.Model.UploadLocalizedPolicyVersionAttachmentResponse? response = wrapper.RequestPresignedURL(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}