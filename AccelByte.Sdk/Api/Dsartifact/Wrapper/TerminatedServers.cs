// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsartifact.Wrapper
{
    public class TerminatedServers
    {
        private readonly AccelByteSDK _sdk;

        public TerminatedServers(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListTerminatedServersWithNamespace.ListTerminatedServersWithNamespaceBuilder ListTerminatedServersWithNamespaceOp
        {
            get { return Operation.ListTerminatedServersWithNamespace.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListTerminatedServersResponse? ListTerminatedServersWithNamespace(ListTerminatedServersWithNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListTerminatedServersResponse?> ListTerminatedServersWithNamespaceAsync(ListTerminatedServersWithNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}