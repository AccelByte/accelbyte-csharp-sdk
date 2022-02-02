using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","updatelocalizationtemplate")]
    public class UpdateLocalizationTemplateCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "UpdateLocalizationTemplate"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("templateLanguage")]
        public string TemplateLanguage { get; set; } = String.Empty;

        [SdkCommandArgument("templateSlug")]
        public string TemplateSlug { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelUpdateTemplateRequest? Body { get; set; }
                
        public UpdateLocalizationTemplateCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            UpdateLocalizationTemplate operation = new UpdateLocalizationTemplate(
                Namespace,                
                TemplateLanguage,                
                TemplateSlug,                
                Body                
            );            

            wrapper.UpdateLocalizationTemplate(operation);
            return String.Empty;
        }
    }
}