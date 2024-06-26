// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Qosm.Wrapper
{
    public class Public
    {
        private readonly AccelByteSDK _sdk;

        public Public(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListServerPerNamespace.ListServerPerNamespaceBuilder ListServerPerNamespaceOp
        {
            get { return Operation.ListServerPerNamespace.Builder.SetWrapperObject(this); }
        }
        public ListServer.ListServerBuilder ListServerOp
        {
            get { return Operation.ListServer.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListServerResponse? ListServerPerNamespace(ListServerPerNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListServerResponse?> ListServerPerNamespaceAsync(ListServerPerNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListServerResponse? ListServer(ListServer input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListServerResponse?> ListServerAsync(ListServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}