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
    [SdkConsoleCommand("lobby","deletetemplatelocalizationv1admin")]
    public class DeleteTemplateLocalizationV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "DeleteTemplateLocalizationV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("templateLanguage")]
        public string TemplateLanguage { get; set; } = String.Empty;

        [SdkCommandArgument("templateSlug")]
        public string TemplateSlug { get; set; } = String.Empty;

        public DeleteTemplateLocalizationV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            DeleteTemplateLocalizationV1Admin operation = new DeleteTemplateLocalizationV1Admin(
                Namespace,                
                TemplateLanguage,                
                TemplateSlug                
            );            

            wrapper.DeleteTemplateLocalizationV1Admin(operation);
            return String.Empty;
        }
    }
}