// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public UpdateServerConfig.UpdateServerConfigBuilder UpdateServerConfigOp
        {
            get { return Operation.UpdateServerConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteServer.DeleteServerBuilder DeleteServerOp
        {
            get { return Operation.DeleteServer.Builder.SetWrapperObject(this); }
        }
        public SetServerAlias.SetServerAliasBuilder SetServerAliasOp
        {
            get { return Operation.SetServerAlias.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void UpdateServerConfig(UpdateServerConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateServerConfigAsync(UpdateServerConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteServer(DeleteServer input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteServerAsync(DeleteServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SetServerAlias(SetServerAlias input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SetServerAliasAsync(SetServerAlias input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}