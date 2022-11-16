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
    [SdkConsoleCommand("session","publicquerymyparties")]
    public class PublicQueryMyPartiesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "PublicQueryMyParties"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("orderBy")]
        public string? OrderBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public PublicQueryMyPartiesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Party wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Party(_SDK);

            PublicQueryMyParties operation = new PublicQueryMyParties(
                Namespace,                
                Order,                
                OrderBy,                
                Status                
            );            
            
            List<AccelByte.Sdk.Api.Session.Model.ApimodelsPartySessionResponse>? response = wrapper.PublicQueryMyParties(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}