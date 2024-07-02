// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Sessionhistory.Wrapper
{
    public class GameSessionDetail
    {
        private readonly AccelByteSDK _sdk;

        public GameSessionDetail(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder AdminQueryGameSessionDetailOp
        {
            get { return Operation.AdminQueryGameSessionDetail.Builder.SetWrapperObject(this); }
        }
        public GetGameSessionDetail.GetGameSessionDetailBuilder GetGameSessionDetailOp
        {
            get { return Operation.GetGameSessionDetail.Builder.SetWrapperObject(this); }
        }
        public AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder AdminQueryMatchmakingDetailOp
        {
            get { return Operation.AdminQueryMatchmakingDetail.Builder.SetWrapperObject(this); }
        }
        public AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder AdminGetMatchmakingDetailBySessionIDOp
        {
            get { return Operation.AdminGetMatchmakingDetailBySessionID.Builder.SetWrapperObject(this); }
        }
        public AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder AdminGetMatchmakingDetailByTicketIDOp
        {
            get { return Operation.AdminGetMatchmakingDetailByTicketID.Builder.SetWrapperObject(this); }
        }
        public AdminQueryPartyDetail.AdminQueryPartyDetailBuilder AdminQueryPartyDetailOp
        {
            get { return Operation.AdminQueryPartyDetail.Builder.SetWrapperObject(this); }
        }
        public GetPartyDetail.GetPartyDetailBuilder GetPartyDetailOp
        {
            get { return Operation.GetPartyDetail.Builder.SetWrapperObject(this); }
        }
        public AdminQueryTicketDetail.AdminQueryTicketDetailBuilder AdminQueryTicketDetailOp
        {
            get { return Operation.AdminQueryTicketDetail.Builder.SetWrapperObject(this); }
        }
        public AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder AdminTicketDetailGetByTicketIDOp
        {
            get { return Operation.AdminTicketDetailGetByTicketID.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsGameSessionDetailQueryResponse? AdminQueryGameSessionDetail(AdminQueryGameSessionDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsGameSessionDetailQueryResponse?> AdminQueryGameSessionDetailAsync(AdminQueryGameSessionDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionDetail? GetGameSessionDetail(GetGameSessionDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsGameSessionDetail?> GetGameSessionDetailAsync(GetGameSessionDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMatchmakingDetailQueryResponse? AdminQueryMatchmakingDetail(AdminQueryMatchmakingDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsMatchmakingDetailQueryResponse?> AdminQueryMatchmakingDetailAsync(AdminQueryMatchmakingDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMatchmakingDetail? AdminGetMatchmakingDetailBySessionID(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsMatchmakingDetail?> AdminGetMatchmakingDetailBySessionIDAsync(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMatchmakingDetail? AdminGetMatchmakingDetailByTicketID(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsMatchmakingDetail?> AdminGetMatchmakingDetailByTicketIDAsync(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartyDetailQueryResponse? AdminQueryPartyDetail(AdminQueryPartyDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsPartyDetailQueryResponse?> AdminQueryPartyDetailAsync(AdminQueryPartyDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartyDetail? GetPartyDetail(GetPartyDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsPartyDetail?> GetPartyDetailAsync(GetPartyDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsTicketDetailQueryResponse? AdminQueryTicketDetail(AdminQueryTicketDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsTicketDetailQueryResponse?> AdminQueryTicketDetailAsync(AdminQueryTicketDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsTicketObservabilityDetail? AdminTicketDetailGetByTicketID(AdminTicketDetailGetByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsTicketObservabilityDetail?> AdminTicketDetailGetByTicketIDAsync(AdminTicketDetailGetByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}