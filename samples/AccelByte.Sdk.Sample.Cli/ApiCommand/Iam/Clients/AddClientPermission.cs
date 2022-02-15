using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","addclientpermission")]
    public class AddClientPermissionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AddClientPermission"; } }

        [SdkCommandArgument("action")]
        public long Action { get; set; } = 0;

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("resource")]
        public string Resource { get; set; } = String.Empty;

        public AddClientPermissionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Clients wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Clients(_SDK);

            AddClientPermission operation = new AddClientPermission(
                Action,                
                ClientId,                
                Resource                
            );            
            
            wrapper.AddClientPermission(operation);
            return String.Empty;
        }
    }
}