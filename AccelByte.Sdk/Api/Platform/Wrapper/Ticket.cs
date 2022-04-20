// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Ticket
    {
        private readonly AccelByteSDK _sdk;

        public Ticket(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetTicketDynamic.GetTicketDynamicBuilder GetTicketDynamicOp
        {
            get { return Operation.GetTicketDynamic.Builder.SetWrapperObject(this); }
        }
        public DecreaseTicketSale.DecreaseTicketSaleBuilder DecreaseTicketSaleOp
        {
            get { return Operation.DecreaseTicketSale.Builder.SetWrapperObject(this); }
        }
        public GetTicketBoothID.GetTicketBoothIDBuilder GetTicketBoothIDOp
        {
            get { return Operation.GetTicketBoothID.Builder.SetWrapperObject(this); }
        }
        public IncreaseTicketSale.IncreaseTicketSaleBuilder IncreaseTicketSaleOp
        {
            get { return Operation.IncreaseTicketSale.Builder.SetWrapperObject(this); }
        }
        public AcquireUserTicket.AcquireUserTicketBuilder AcquireUserTicketOp
        {
            get { return Operation.AcquireUserTicket.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.TicketDynamicInfo? GetTicketDynamic(GetTicketDynamic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DecreaseTicketSale(DecreaseTicketSale input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TicketBoothID? GetTicketBoothID(GetTicketBoothID input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TicketSaleIncrementResult? IncreaseTicketSale(IncreaseTicketSale input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TicketAcquireResult? AcquireUserTicket(AcquireUserTicket input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Ticket_OperationExtensions
    {
        public static Model.TicketDynamicInfo? Execute(
            this GetTicketDynamic.GetTicketDynamicBuilder builder,
            string boothName,
            string namespace_
        )
        {
            GetTicketDynamic op = builder.Build(
                boothName,
                namespace_
            );

            return ((Ticket)builder.WrapperObject!).GetTicketDynamic(op);
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

            ((Ticket)builder.WrapperObject!).DecreaseTicketSale(op);
        }

        public static Model.TicketBoothID? Execute(
            this GetTicketBoothID.GetTicketBoothIDBuilder builder,
            string boothName,
            string namespace_
        )
        {
            GetTicketBoothID op = builder.Build(
                boothName,
                namespace_
            );

            return ((Ticket)builder.WrapperObject!).GetTicketBoothID(op);
        }

        public static Model.TicketSaleIncrementResult? Execute(
            this IncreaseTicketSale.IncreaseTicketSaleBuilder builder,
            string boothName,
            string namespace_
        )
        {
            IncreaseTicketSale op = builder.Build(
                boothName,
                namespace_
            );

            return ((Ticket)builder.WrapperObject!).IncreaseTicketSale(op);
        }

        public static Model.TicketAcquireResult? Execute(
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

            return ((Ticket)builder.WrapperObject!).AcquireUserTicket(op);
        }

    }
}