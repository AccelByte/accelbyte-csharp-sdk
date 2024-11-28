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

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session", "adminuploadxboxcertificate")]
    public class AdminUploadXBoxCertificateCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminUploadXBoxCertificate"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("description")]
        public string Description { get; set; } = String.Empty;

        [SdkCommandArgument("certname")]
        public string Certname { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream File { get; set; } = new MemoryStream();

        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;

        public AdminUploadXBoxCertificateCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Certificate wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Certificate(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminUploadXBoxCertificate.Builder;



            if (Description != null)
                opBuilder.SetDescription((string)Description);


            AdminUploadXBoxCertificate operation = opBuilder.Build(
                Certname,
                File,
                Password,
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Session.Model.ModelsPlatformCredentials? response = wrapper.AdminUploadXBoxCertificate(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}