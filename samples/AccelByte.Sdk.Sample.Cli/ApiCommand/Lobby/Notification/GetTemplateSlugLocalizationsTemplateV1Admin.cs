// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","gettemplatesluglocalizationstemplatev1admin")]
    public class GetTemplateSlugLocalizationsTemplateV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "GetTemplateSlugLocalizationsTemplateV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("templateSlug")]
        public string TemplateSlug { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public GetTemplateSlugLocalizationsTemplateV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            GetTemplateSlugLocalizationsTemplateV1Admin operation = new GetTemplateSlugLocalizationsTemplateV1Admin(
                Namespace,                
                TemplateSlug,                
                After,                
                Before,                
                Limit                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelGetAllNotificationTemplateSlugResp? response = wrapper.GetTemplateSlugLocalizationsTemplateV1Admin(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}