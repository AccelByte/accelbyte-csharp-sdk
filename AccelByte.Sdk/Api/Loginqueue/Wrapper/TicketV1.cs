// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Loginqueue.Model;
using AccelByte.Sdk.Api.Loginqueue.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Loginqueue.Wrapper
{
    public class TicketV1
    {
        private readonly AccelByteSDK _sdk;

        public TicketV1(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RefreshTicket.RefreshTicketBuilder RefreshTicketOp
        {
            get { return Operation.RefreshTicket.Builder.SetWrapperObject(this); }
        }
        public CancelTicket.CancelTicketBuilder CancelTicketOp
        {
            get { return Operation.CancelTicket.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsRefreshTicketResponse? RefreshTicket(RefreshTicket input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsRefreshTicketResponse?> RefreshTicketAsync(RefreshTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CancelTicket(CancelTicket input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CancelTicketAsync(CancelTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}