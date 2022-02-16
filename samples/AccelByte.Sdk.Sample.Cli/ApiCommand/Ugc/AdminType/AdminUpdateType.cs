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
    [SdkConsoleCommand("ugc","adminupdatetype")]
    public class AdminUpdateTypeCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminUpdateType"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("typeId")]
        public string TypeId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateTypeRequest Body { get; set; } = new ModelsCreateTypeRequest();
                
        public AdminUpdateTypeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminType wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminType(_SDK);

            AdminUpdateType operation = new AdminUpdateType(
                Namespace,                
                TypeId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateTypeResponse? response = wrapper.AdminUpdateType(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}