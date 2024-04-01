// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class EQU8Config
    {
        private readonly AccelByteSDK _sdk;

        public EQU8Config(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetConfig.GetConfigBuilder GetConfigOp
        {
            get { return Operation.GetConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteConfig.DeleteConfigBuilder DeleteConfigOp
        {
            get { return Operation.DeleteConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateConfig.UpdateConfigBuilder UpdateConfigOp
        {
            get { return Operation.UpdateConfig.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.Equ8Config? GetConfig(GetConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.Equ8Config?> GetConfigAsync(GetConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteConfig(DeleteConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteConfigAsync(DeleteConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Equ8Config? UpdateConfig(UpdateConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.Equ8Config?> UpdateConfigAsync(UpdateConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}