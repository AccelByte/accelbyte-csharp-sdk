// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","publicgetcontentbulk")]
    public class PublicGetContentBulkCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "PublicGetContentBulk"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsPublicGetContentBulkRequest Body { get; set; } = new ModelsPublicGetContentBulkRequest();
                
        public PublicGetContentBulkCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicContent(_SDK);

            PublicGetContentBulk operation = new PublicGetContentBulk(
                Namespace,                
                Body                
            );            
            
            List<AccelByte.Sdk.Api.Ugc.Model.ModelsContentDownloadResponse>? response = wrapper.PublicGetContentBulk(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}