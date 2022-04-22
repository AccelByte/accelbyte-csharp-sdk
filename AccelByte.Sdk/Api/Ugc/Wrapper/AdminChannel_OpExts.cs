// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcAdminChannel_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGetChannelResponse? Execute(
            this SingleAdminGetChannel.SingleAdminGetChannelBuilder builder,
            string namespace_
        )
        {
            SingleAdminGetChannel op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).SingleAdminGetChannel(op);
        }

        public static Ugc.Model.ModelsChannelResponse? Execute(
            this AdminCreateChannel.AdminCreateChannelBuilder builder,
            ModelsChannelRequest body,
            string namespace_
        )
        {
            AdminCreateChannel op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).AdminCreateChannel(op);
        }

        public static Ugc.Model.ModelsChannelResponse? Execute(
            this SingleAdminUpdateChannel.SingleAdminUpdateChannelBuilder builder,
            ModelsChannelRequest body,
            string channelId,
            string namespace_
        )
        {
            SingleAdminUpdateChannel op = builder.Build(
                body,
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).SingleAdminUpdateChannel(op);
        }

        public static void Execute(
            this SingleAdminDeleteChannel.SingleAdminDeleteChannelBuilder builder,
            string channelId,
            string namespace_
        )
        {
            SingleAdminDeleteChannel op = builder.Build(
                channelId,
                namespace_
            );

            ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).SingleAdminDeleteChannel(op);
        }

        public static Ugc.Model.ModelsPaginatedGetChannelResponse? Execute(
            this AdminGetChannel.AdminGetChannelBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetChannel op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).AdminGetChannel(op);
        }

        public static Ugc.Model.ModelsChannelResponse? Execute(
            this AdminUpdateChannel.AdminUpdateChannelBuilder builder,
            ModelsChannelRequest body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateChannel op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).AdminUpdateChannel(op);
        }

        public static void Execute(
            this AdminDeleteChannel.AdminDeleteChannelBuilder builder,
            string channelId,
            string namespace_,
            string userId
        )
        {
            AdminDeleteChannel op = builder.Build(
                channelId,
                namespace_,
                userId
            );

            ((Ugc.Wrapper.AdminChannel)builder.WrapperObject!).AdminDeleteChannel(op);
        }

    }
}