using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","debituserwallet")]
    public class DebitUserWalletCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DebitUserWallet"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("walletId")]
        public string WalletId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public DebitRequest Body { get; set; } = new DebitRequest();
                
        public DebitUserWalletCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Wallet wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Wallet(_SDK);

            DebitUserWallet operation = new DebitUserWallet(
                Namespace,                
                UserId,                
                WalletId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.WalletInfo? response = wrapper.DebitUserWallet(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}