// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformTicket_OpExts
    {
        public static Platform.Model.TicketDynamicInfo? Execute(
            this GetTicketDynamic.GetTicketDynamicBuilder builder,
            string boothName,
            string namespace_
        )
        {
            GetTicketDynamic op = builder.Build(
                boothName,
                namespace_
            );

            return ((Platform.Wrapper.Ticket)builder.WrapperObject!).GetTicketDynamic(op);
        }

        public static void Execute(
            this DecreaseTicketSale.DecreaseTicketSaleBuilder builder,
            string boothName,
            string namespace_
        )
        {
            DecreaseTicketSale op = builder.Build(
                boothName,
                namespace_
            );

            ((Platform.Wrapper.Ticket)builder.WrapperObject!).DecreaseTicketSale(op);
        }

        public static Platform.Model.TicketBoothID? Execute(
            this GetTicketBoothID.GetTicketBoothIDBuilder builder,
            string boothName,
            string namespace_
        )
        {
            GetTicketBoothID op = builder.Build(
                boothName,
                namespace_
            );

            return ((Platform.Wrapper.Ticket)builder.WrapperObject!).GetTicketBoothID(op);
        }

        public static Platform.Model.TicketSaleIncrementResult? Execute(
            this IncreaseTicketSale.IncreaseTicketSaleBuilder builder,
            string boothName,
            string namespace_
        )
        {
            IncreaseTicketSale op = builder.Build(
                boothName,
                namespace_
            );

            return ((Platform.Wrapper.Ticket)builder.WrapperObject!).IncreaseTicketSale(op);
        }

        public static Platform.Model.TicketAcquireResult? Execute(
            this AcquireUserTicket.AcquireUserTicketBuilder builder,
            string boothName,
            string namespace_,
            string userId
        )
        {
            AcquireUserTicket op = builder.Build(
                boothName,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Ticket)builder.WrapperObject!).AcquireUserTicket(op);
        }

    }
}