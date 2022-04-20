// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Qosm.Wrapper
{
    public class Admin
    {
        private readonly AccelByteSDK _sdk;

        public Admin(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public DeleteServer.DeleteServerBuilder DeleteServerOp
        {
            get { return Operation.DeleteServer.Builder.SetWrapperObject(this); }
        }
        public SetServerAlias.SetServerAliasBuilder SetServerAliasOp
        {
            get { return Operation.SetServerAlias.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void DeleteServer(DeleteServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetServerAlias(SetServerAlias input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Admin_OperationExtensions
    {
        public static void Execute(
            this DeleteServer.DeleteServerBuilder builder,
            string region
        )
        {
            DeleteServer op = builder.Build(
                region
            );

            ((Admin)builder.WrapperObject!).DeleteServer(op);
        }

        public static void Execute(
            this SetServerAlias.SetServerAliasBuilder builder,
            ModelsSetAliasRequest body,
            string region
        )
        {
            SetServerAlias op = builder.Build(
                body,
                region
            );

            ((Admin)builder.WrapperObject!).SetServerAlias(op);
        }

    }
}