// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class MatchmakingMockMatchmaking_OpExts
    {
        public static void Execute(
            this CleanAllMocks.CleanAllMocksBuilder builder,
            string channelName,
            string namespace_
        )
        {
            CleanAllMocks op = builder.Build(
                channelName,
                namespace_
            );

            ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).CleanAllMocks(op);
        }
        public static async Task ExecuteAsync(
            this CleanAllMocks.CleanAllMocksBuilder builder,
            string channelName,
            string namespace_
        )
        {
            CleanAllMocks op = builder.Build(
                channelName,
                namespace_
            );

            await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).CleanAllMocksAsync(op);
        }
        public static Matchmaking.Model.ModelsGetMockMatchesResponse? Execute(
            this GetAllMockMatches.GetAllMockMatchesBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllMockMatches op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetAllMockMatches(op);
        }
        public static async Task<Matchmaking.Model.ModelsGetMockMatchesResponse?> ExecuteAsync(
            this GetAllMockMatches.GetAllMockMatchesBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllMockMatches op = builder.Build(
                channelName,
                namespace_
            );

            return await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetAllMockMatchesAsync(op);
        }
        public static Matchmaking.Model.ModelsGetMockMatchesResponse? Execute(
            this GetMockMatchesByTimestamp.GetMockMatchesByTimestampBuilder builder,
            ModelsQueryMockBy body,
            string channelName,
            string namespace_
        )
        {
            GetMockMatchesByTimestamp op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetMockMatchesByTimestamp(op);
        }
        public static async Task<Matchmaking.Model.ModelsGetMockMatchesResponse?> ExecuteAsync(
            this GetMockMatchesByTimestamp.GetMockMatchesByTimestampBuilder builder,
            ModelsQueryMockBy body,
            string channelName,
            string namespace_
        )
        {
            GetMockMatchesByTimestamp op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetMockMatchesByTimestampAsync(op);
        }
        public static Matchmaking.Model.ModelsGetMockTicketsResponse? Execute(
            this GetAllMockTickets.GetAllMockTicketsBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllMockTickets op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetAllMockTickets(op);
        }
        public static async Task<Matchmaking.Model.ModelsGetMockTicketsResponse?> ExecuteAsync(
            this GetAllMockTickets.GetAllMockTicketsBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllMockTickets op = builder.Build(
                channelName,
                namespace_
            );

            return await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetAllMockTicketsAsync(op);
        }
        public static List<Matchmaking.Model.ModelsMockTicket>? Execute(
            this CreateMockTickets.CreateMockTicketsBuilder builder,
            ModelsCreateMockTicket body,
            string channelName,
            string namespace_
        )
        {
            CreateMockTickets op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).CreateMockTickets(op);
        }
        public static async Task<List<Matchmaking.Model.ModelsMockTicket>?> ExecuteAsync(
            this CreateMockTickets.CreateMockTicketsBuilder builder,
            ModelsCreateMockTicket body,
            string channelName,
            string namespace_
        )
        {
            CreateMockTickets op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).CreateMockTicketsAsync(op);
        }

        public static List<Matchmaking.Model.ModelsMockTicket<T1, T2>>? Execute<T1, T2>(
            this CreateMockTickets.CreateMockTicketsBuilder builder,
            ModelsCreateMockTicket body,
            string channelName,
            string namespace_
        )
        {
            CreateMockTickets op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).CreateMockTickets<T1, T2>(op);
        }
        public static async Task<List<Matchmaking.Model.ModelsMockTicket<T1, T2>>?> ExecuteAsync<T1, T2>(
            this CreateMockTickets.CreateMockTicketsBuilder builder,
            ModelsCreateMockTicket body,
            string channelName,
            string namespace_
        )
        {
            CreateMockTickets op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).CreateMockTicketsAsync<T1, T2>(op);
        }
        public static void Execute(
            this BulkCreateMockTickets.BulkCreateMockTicketsBuilder builder,
            List<ModelsMatchingParty> body,
            string channelName,
            string namespace_
        )
        {
            BulkCreateMockTickets op = builder.Build(
                body,
                channelName,
                namespace_
            );

            ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).BulkCreateMockTickets(op);
        }
        public static async Task ExecuteAsync(
            this BulkCreateMockTickets.BulkCreateMockTicketsBuilder builder,
            List<ModelsMatchingParty> body,
            string channelName,
            string namespace_
        )
        {
            BulkCreateMockTickets op = builder.Build(
                body,
                channelName,
                namespace_
            );

            await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).BulkCreateMockTicketsAsync(op);
        }
        public static Matchmaking.Model.ModelsGetMockTicketsResponse? Execute(
            this GetMockTicketsByTimestamp.GetMockTicketsByTimestampBuilder builder,
            ModelsQueryMockBy body,
            string channelName,
            string namespace_
        )
        {
            GetMockTicketsByTimestamp op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetMockTicketsByTimestamp(op);
        }
        public static async Task<Matchmaking.Model.ModelsGetMockTicketsResponse?> ExecuteAsync(
            this GetMockTicketsByTimestamp.GetMockTicketsByTimestampBuilder builder,
            ModelsQueryMockBy body,
            string channelName,
            string namespace_
        )
        {
            GetMockTicketsByTimestamp op = builder.Build(
                body,
                channelName,
                namespace_
            );

            return await ((Matchmaking.Wrapper.MockMatchmaking)builder.WrapperObject!).GetMockTicketsByTimestampAsync(op);
        }
    }
}