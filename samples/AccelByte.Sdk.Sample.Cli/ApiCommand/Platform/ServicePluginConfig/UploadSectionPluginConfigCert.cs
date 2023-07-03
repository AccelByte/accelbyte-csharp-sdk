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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "uploadsectionpluginconfigcert")]
    public class UploadSectionPluginConfigCertCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "UploadSectionPluginConfigCert"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream? File { get; set; }

        public UploadSectionPluginConfigCertCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.ServicePluginConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.ServicePluginConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UploadSectionPluginConfigCert.Builder;



            if (File != null)
                opBuilder.SetFile((Stream)File);


            UploadSectionPluginConfigCert operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.SectionPluginConfigInfo? response = wrapper.UploadSectionPluginConfigCert(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}