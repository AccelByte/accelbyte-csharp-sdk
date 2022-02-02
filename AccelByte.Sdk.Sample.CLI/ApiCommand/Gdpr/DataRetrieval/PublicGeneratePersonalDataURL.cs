using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","publicgeneratepersonaldataurl")]
    public class PublicGeneratePersonalDataURLCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "PublicGeneratePersonalDataURL"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("requestDate")]
        public string RequestDate { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        public PublicGeneratePersonalDataURLCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval(_SDK);

            PublicGeneratePersonalDataURL operation = new PublicGeneratePersonalDataURL(
                Namespace,                
                RequestDate,                
                UserId,                
                Password                
            );            

            AccelByte.Sdk.Api.Gdpr.Model.ModelsUserDataURL? response = wrapper.PublicGeneratePersonalDataURL(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}