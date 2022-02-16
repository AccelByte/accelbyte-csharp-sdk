// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","admingeneratepersonaldataurl")]
    public class AdminGeneratePersonalDataURLCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminGeneratePersonalDataURL"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("requestDate")]
        public string RequestDate { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        public AdminGeneratePersonalDataURLCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval(_SDK);

            AdminGeneratePersonalDataURL operation = new AdminGeneratePersonalDataURL(
                Namespace,                
                RequestDate,                
                UserId,                
                Password                
            );            
            
            AccelByte.Sdk.Api.Gdpr.Model.ModelsUserDataURL? response = wrapper.AdminGeneratePersonalDataURL(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}