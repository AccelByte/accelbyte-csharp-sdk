// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicChannel_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGetChannelResponse? Execute(
            this GetChannels.GetChannelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetChannels op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicChannel)builder.WrapperObject!).GetChannels(op);
        }

        public static Ugc.Model.ModelsChannelResponse? Execute(
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

            return ((Ugc.Wrapper.PublicChannel)builder.WrapperObject!).CreateChannel(op);
        }

        public static Ugc.Model.ModelsChannelResponse? Execute(
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

            return ((Ugc.Wrapper.PublicChannel)builder.WrapperObject!).UpdateChannel(op);
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

            ((Ugc.Wrapper.PublicChannel)builder.WrapperObject!).DeleteChannel(op);
        }

    }
}