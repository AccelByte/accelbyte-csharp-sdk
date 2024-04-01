// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicChannel
    {
        private readonly AccelByteSDK _sdk;

        public PublicChannel(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetChannels.GetChannelsBuilder GetChannelsOp
        {
            get { return Operation.GetChannels.Builder.SetWrapperObject(this); }
        }
        public PublicCreateChannel.PublicCreateChannelBuilder PublicCreateChannelOp
        {
            get { return Operation.PublicCreateChannel.Builder.SetWrapperObject(this); }
        }
        public UpdateChannel.UpdateChannelBuilder UpdateChannelOp
        {
            get { return Operation.UpdateChannel.Builder.SetWrapperObject(this); }
        }
        public DeleteChannel.DeleteChannelBuilder DeleteChannelOp
        {
            get { return Operation.DeleteChannel.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPaginatedGetChannelResponse? GetChannels(GetChannels input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedGetChannelResponse?> GetChannelsAsync(GetChannels input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? PublicCreateChannel(PublicCreateChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChannelResponse?> PublicCreateChannelAsync(PublicCreateChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? UpdateChannel(UpdateChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsChannelResponse?> UpdateChannelAsync(UpdateChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteChannel(DeleteChannel input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteChannelAsync(DeleteChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}