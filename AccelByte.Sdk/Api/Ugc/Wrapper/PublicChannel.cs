// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public CreateChannel.CreateChannelBuilder CreateChannelOp
        {
            get { return Operation.CreateChannel.Builder.SetWrapperObject(this); }
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
        
        public Model.ModelsPaginatedGetChannelResponse? GetChannels(GetChannels input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? CreateChannel(CreateChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? UpdateChannel(UpdateChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteChannel(DeleteChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PublicChannel_OperationExtensions
    {
        public static Model.ModelsPaginatedGetChannelResponse? Execute(
            this GetChannels.GetChannelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetChannels op = builder.Build(
                namespace_,
                userId
            );

            return ((PublicChannel)builder.WrapperObject!).GetChannels(op);
        }

        public static Model.ModelsChannelResponse? Execute(
            this CreateChannel.CreateChannelBuilder builder,
            ModelsChannelRequest body,
            string namespace_,
            string userId
        )
        {
            CreateChannel op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((PublicChannel)builder.WrapperObject!).CreateChannel(op);
        }

        public static Model.ModelsChannelResponse? Execute(
            this UpdateChannel.UpdateChannelBuilder builder,
            ModelsChannelRequest body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            UpdateChannel op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return ((PublicChannel)builder.WrapperObject!).UpdateChannel(op);
        }

        public static void Execute(
            this DeleteChannel.DeleteChannelBuilder builder,
            string channelId,
            string namespace_,
            string userId
        )
        {
            DeleteChannel op = builder.Build(
                channelId,
                namespace_,
                userId
            );

            ((PublicChannel)builder.WrapperObject!).DeleteChannel(op);
        }

    }
}