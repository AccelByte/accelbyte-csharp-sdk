using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dslogmanager
{
    [SdkConsoleCommand("dslogmanager","listterminatedservers")]
    public class ListTerminatedServersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dslogmanager"; } }

        public string OperationName{ get { return "ListTerminatedServers"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("deployment")]
        public string? Deployment { get; set; }

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("gameMode")]
        public string? GameMode { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("next")]
        public string? Next { get; set; }

        [SdkCommandArgument("partyId")]
        public string? PartyId { get; set; }

        [SdkCommandArgument("podName")]
        public string? PodName { get; set; }

        [SdkCommandArgument("previous")]
        public string? Previous { get; set; }

        [SdkCommandArgument("provider")]
        public string? Provider { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("sessionId")]
        public string? SessionId { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public ListTerminatedServersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.TerminatedServers wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.TerminatedServers(_SDK);

            ListTerminatedServers operation = new ListTerminatedServers(
                Namespace,                
                Deployment,                
                EndDate,                
                GameMode,                
                Limit,                
                Next,                
                PartyId,                
                PodName,                
                Previous,                
                Provider,                
                Region,                
                SessionId,                
                StartDate,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Dslogmanager.Model.ModelsListTerminatedServersResponse? response = wrapper.ListTerminatedServers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}