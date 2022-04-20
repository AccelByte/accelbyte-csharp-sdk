// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class MatchmakingMatchmaking_OpExts
    {
        public static Matchmaking.Model.ModelsGetChannelsResponse? Execute(
            this GetAllChannelsHandler.GetAllChannelsHandlerBuilder builder,
            string namespace_
        )
        {
            GetAllChannelsHandler op = builder.Build(
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).GetAllChannelsHandler(op);
        }

        public static Matchmaking.Model.ModelsCreateChannelResponse? Execute(
            this CreateChannelHandler.CreateChannelHandlerBuilder builder,
            ModelsChannelRequest body,
            string namespace_
        )
        {
            CreateChannelHandler op = builder.Build(
                body,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).CreateChannelHandler(op);
        }

        public static void Execute(
            this DeleteChannelHandler.DeleteChannelHandlerBuilder builder,
            string channel,
            string namespace_
        )
        {
            DeleteChannelHandler op = builder.Build(
                channel,
                namespace_
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).DeleteChannelHandler(op);
        }

        public static Matchmaking.Model.ModelsMatchResultResponse? Execute(
            this StoreMatchResults.StoreMatchResultsBuilder builder,
            ModelsMatchResultRequest body,
            string namespace_
        )
        {
            StoreMatchResults op = builder.Build(
                body,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).StoreMatchResults(op);
        }

        public static void Execute(
            this QueueSessionHandler.QueueSessionHandlerBuilder builder,
            ModelsMatchmakingResult body,
            string namespace_
        )
        {
            QueueSessionHandler op = builder.Build(
                body,
                namespace_
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).QueueSessionHandler(op);
        }

        public static void Execute(
            this DequeueSessionHandler.DequeueSessionHandlerBuilder builder,
            ModelsDequeueRequest body,
            string namespace_
        )
        {
            DequeueSessionHandler op = builder.Build(
                body,
                namespace_
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).DequeueSessionHandler(op);
        }

        public static Matchmaking.Model.ModelsMatchmakingResult? Execute(
            this QuerySessionHandler.QuerySessionHandlerBuilder builder,
            string matchID,
            string namespace_
        )
        {
            QuerySessionHandler op = builder.Build(
                matchID,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).QuerySessionHandler(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetAllPartyInAllChannel.GetAllPartyInAllChannelBuilder builder,
            string namespace_
        )
        {
            GetAllPartyInAllChannel op = builder.Build(
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).GetAllPartyInAllChannel(op);
        }

        public static List<Matchmaking.Model.ModelsMatchmakingResult>? Execute(
            this BulkGetSessions.BulkGetSessionsBuilder builder,
            string namespace_
        )
        {
            BulkGetSessions op = builder.Build(
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).BulkGetSessions(op);
        }

        public static List<Matchmaking.Model.ModelsChannelV1>? Execute(
            this ExportChannels.ExportChannelsBuilder builder,
            string namespace_
        )
        {
            ExportChannels op = builder.Build(
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).ExportChannels(op);
        }

        public static Matchmaking.Model.ModelsImportConfigResponse? Execute(
            this ImportChannels.ImportChannelsBuilder builder,
            string namespace_
        )
        {
            ImportChannels op = builder.Build(
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).ImportChannels(op);
        }

        public static Matchmaking.Model.ModelsChannelV1? Execute(
            this GetSingleMatchmakingChannel.GetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetSingleMatchmakingChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).GetSingleMatchmakingChannel(op);
        }

        public static void Execute(
            this UpdateMatchmakingChannel.UpdateMatchmakingChannelBuilder builder,
            ModelsUpdateChannelRequest body,
            string channelName,
            string namespace_
        )
        {
            UpdateMatchmakingChannel op = builder.Build(
                body,
                channelName,
                namespace_
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).UpdateMatchmakingChannel(op);
        }

        public static List<Matchmaking.Model.ModelsMatchingParty>? Execute(
            this GetAllPartyInChannel.GetAllPartyInChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllPartyInChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).GetAllPartyInChannel(op);
        }

        public static List<Matchmaking.Model.ModelsMatchmakingResult>? Execute(
            this GetAllSessionsInChannel.GetAllSessionsInChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllSessionsInChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).GetAllSessionsInChannel(op);
        }

        public static void Execute(
            this AddUserIntoSessionInChannel.AddUserIntoSessionInChannelBuilder builder,
            ModelsMatchAddUserIntoSessionRequest body,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            AddUserIntoSessionInChannel op = builder.Build(
                body,
                channelName,
                matchID,
                namespace_
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).AddUserIntoSessionInChannel(op);
        }

        public static void Execute(
            this DeleteSessionInChannel.DeleteSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            DeleteSessionInChannel op = builder.Build(
                channelName,
                matchID,
                namespace_
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).DeleteSessionInChannel(op);
        }

        public static void Execute(
            this DeleteUserFromSessionInChannel.DeleteUserFromSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_,
            string userID
        )
        {
            DeleteUserFromSessionInChannel op = builder.Build(
                channelName,
                matchID,
                namespace_,
                userID
            );

            ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).DeleteUserFromSessionInChannel(op);
        }

        public static Matchmaking.Model.ServiceGetSessionHistorySearchResponse? Execute(
            this SearchSessions.SearchSessionsBuilder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            SearchSessions op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).SearchSessions(op);
        }

        public static List<Matchmaking.Model.ServiceGetSessionHistoryDetailedResponseItem>? Execute(
            this GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            GetSessionHistoryDetailed op = builder.Build(
                matchID,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).GetSessionHistoryDetailed(op);
        }

        public static List<Matchmaking.Model.ModelsChannelV1>? Execute(
            this PublicGetAllMatchmakingChannel.PublicGetAllMatchmakingChannelBuilder builder,
            string namespace_
        )
        {
            PublicGetAllMatchmakingChannel op = builder.Build(
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).PublicGetAllMatchmakingChannel(op);
        }

        public static Matchmaking.Model.ModelsChannelV1? Execute(
            this PublicGetSingleMatchmakingChannel.PublicGetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PublicGetSingleMatchmakingChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).PublicGetSingleMatchmakingChannel(op);
        }

        public static Matchmaking.Model.ServiceGetSessionHistorySearchResponseV2? Execute(
            this SearchSessionsV2.SearchSessionsV2Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            SearchSessionsV2 op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((Matchmaking.Wrapper.Matchmaking)builder.WrapperObject!).SearchSessionsV2(op);
        }

    }
}