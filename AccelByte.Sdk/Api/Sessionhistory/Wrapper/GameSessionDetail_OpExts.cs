// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;
using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionhistoryGameSessionDetail_OpExts
    {
        public static Sessionhistory.Model.ApimodelsGameSessionDetailQueryResponse? Execute(
            this AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryGameSessionDetail op = builder.Build(
                namespace_
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryGameSessionDetail(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsGameSessionDetailQueryResponse?> ExecuteAsync(
            this AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryGameSessionDetail op = builder.Build(
                namespace_
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryGameSessionDetailAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsGameSessionDetail? Execute(
            this GetGameSessionDetail.GetGameSessionDetailBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSessionDetail op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).GetGameSessionDetail(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsGameSessionDetail?> ExecuteAsync(
            this GetGameSessionDetail.GetGameSessionDetailBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSessionDetail op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).GetGameSessionDetailAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsMatchmakingDetailQueryResponse? Execute(
            this AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryMatchmakingDetail op = builder.Build(
                namespace_
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryMatchmakingDetail(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsMatchmakingDetailQueryResponse?> ExecuteAsync(
            this AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryMatchmakingDetail op = builder.Build(
                namespace_
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryMatchmakingDetailAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsMatchmakingDetail? Execute(
            this AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            AdminGetMatchmakingDetailBySessionID op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminGetMatchmakingDetailBySessionID(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsMatchmakingDetail?> ExecuteAsync(
            this AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            AdminGetMatchmakingDetailBySessionID op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminGetMatchmakingDetailBySessionIDAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsMatchmakingDetail? Execute(
            this AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            AdminGetMatchmakingDetailByTicketID op = builder.Build(
                namespace_,
                ticketId
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminGetMatchmakingDetailByTicketID(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsMatchmakingDetail?> ExecuteAsync(
            this AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            AdminGetMatchmakingDetailByTicketID op = builder.Build(
                namespace_,
                ticketId
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminGetMatchmakingDetailByTicketIDAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsPartyDetailQueryResponse? Execute(
            this AdminQueryPartyDetail.AdminQueryPartyDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryPartyDetail op = builder.Build(
                namespace_
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryPartyDetail(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsPartyDetailQueryResponse?> ExecuteAsync(
            this AdminQueryPartyDetail.AdminQueryPartyDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryPartyDetail op = builder.Build(
                namespace_
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryPartyDetailAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsPartyDetail? Execute(
            this GetPartyDetail.GetPartyDetailBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetPartyDetail op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).GetPartyDetail(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsPartyDetail?> ExecuteAsync(
            this GetPartyDetail.GetPartyDetailBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetPartyDetail op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).GetPartyDetailAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsTicketDetailQueryResponse? Execute(
            this AdminQueryTicketDetail.AdminQueryTicketDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryTicketDetail op = builder.Build(
                namespace_
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryTicketDetail(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsTicketDetailQueryResponse?> ExecuteAsync(
            this AdminQueryTicketDetail.AdminQueryTicketDetailBuilder builder,
            string namespace_
        )
        {
            AdminQueryTicketDetail op = builder.Build(
                namespace_
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminQueryTicketDetailAsync(op);
        }
        public static Sessionhistory.Model.ApimodelsTicketObservabilityDetail? Execute(
            this AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            AdminTicketDetailGetByTicketID op = builder.Build(
                namespace_,
                ticketId
            );

            return ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminTicketDetailGetByTicketID(op);
        }
        public static async Task<Sessionhistory.Model.ApimodelsTicketObservabilityDetail?> ExecuteAsync(
            this AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            AdminTicketDetailGetByTicketID op = builder.Build(
                namespace_,
                ticketId
            );

            return await ((Sessionhistory.Wrapper.GameSessionDetail)builder.WrapperObject!).AdminTicketDetailGetByTicketIDAsync(op);
        }
    }
}