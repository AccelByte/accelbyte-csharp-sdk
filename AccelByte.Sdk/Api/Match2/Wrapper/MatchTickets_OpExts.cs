// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;
using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class Match2MatchTickets_OpExts
    {
        public static Match2.Model.ApiMatchTicketResponse? Execute(
            this CreateMatchTicket.CreateMatchTicketBuilder builder,
            ApiMatchTicketRequest body,
            string namespace_
        )
        {
            CreateMatchTicket op = builder.Build(
                body,
                namespace_
            );

            return ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).CreateMatchTicket(op);
        }
        public static async Task<Match2.Model.ApiMatchTicketResponse?> ExecuteAsync(
            this CreateMatchTicket.CreateMatchTicketBuilder builder,
            ApiMatchTicketRequest body,
            string namespace_
        )
        {
            CreateMatchTicket op = builder.Build(
                body,
                namespace_
            );

            return await ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).CreateMatchTicketAsync(op);
        }
        public static Match2.Model.ApiMatchTicketStatuses? Execute(
            this GetMyMatchTickets.GetMyMatchTicketsBuilder builder,
            string namespace_
        )
        {
            GetMyMatchTickets op = builder.Build(
                namespace_
            );

            return ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).GetMyMatchTickets(op);
        }
        public static async Task<Match2.Model.ApiMatchTicketStatuses?> ExecuteAsync(
            this GetMyMatchTickets.GetMyMatchTicketsBuilder builder,
            string namespace_
        )
        {
            GetMyMatchTickets op = builder.Build(
                namespace_
            );

            return await ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).GetMyMatchTicketsAsync(op);
        }
        public static Match2.Model.ApiMatchTicketStatus? Execute(
            this MatchTicketDetails.MatchTicketDetailsBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            MatchTicketDetails op = builder.Build(
                namespace_,
                ticketid
            );

            return ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).MatchTicketDetails(op);
        }
        public static async Task<Match2.Model.ApiMatchTicketStatus?> ExecuteAsync(
            this MatchTicketDetails.MatchTicketDetailsBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            MatchTicketDetails op = builder.Build(
                namespace_,
                ticketid
            );

            return await ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).MatchTicketDetailsAsync(op);
        }
        public static void Execute(
            this DeleteMatchTicket.DeleteMatchTicketBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            DeleteMatchTicket op = builder.Build(
                namespace_,
                ticketid
            );

            ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).DeleteMatchTicket(op);
        }
        public static async Task ExecuteAsync(
            this DeleteMatchTicket.DeleteMatchTicketBuilder builder,
            string namespace_,
            string ticketid
        )
        {
            DeleteMatchTicket op = builder.Build(
                namespace_,
                ticketid
            );

            await ((Match2.Wrapper.MatchTickets)builder.WrapperObject!).DeleteMatchTicketAsync(op);
        }
    }
}