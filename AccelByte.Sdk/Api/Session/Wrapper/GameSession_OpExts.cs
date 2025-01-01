// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionGameSession_OpExts
    {
        public static Session.Model.ApimodelsGameSessionQueryResponse? Execute(
            this AdminQueryGameSessions.AdminQueryGameSessionsBuilder builder,
            string namespace_
        )
        {
            AdminQueryGameSessions op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminQueryGameSessions(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionQueryResponse?> ExecuteAsync(
            this AdminQueryGameSessions.AdminQueryGameSessionsBuilder builder,
            string namespace_
        )
        {
            AdminQueryGameSessions op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminQueryGameSessionsAsync(op);
        }
        public static Session.Model.ApimodelsGameSessionQueryResponse? Execute(
            this AdminQueryGameSessionsByAttributes.AdminQueryGameSessionsByAttributesBuilder builder,
            Dictionary<string, object> body,
            string namespace_
        )
        {
            AdminQueryGameSessionsByAttributes op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminQueryGameSessionsByAttributes(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionQueryResponse?> ExecuteAsync(
            this AdminQueryGameSessionsByAttributes.AdminQueryGameSessionsByAttributesBuilder builder,
            Dictionary<string, object> body,
            string namespace_
        )
        {
            AdminQueryGameSessionsByAttributes op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminQueryGameSessionsByAttributesAsync(op);
        }
        public static Session.Model.ApimodelsDeleteBulkGameSessionsAPIResponse? Execute(
            this AdminDeleteBulkGameSessions.AdminDeleteBulkGameSessionsBuilder builder,
            ApimodelsDeleteBulkGameSessionRequest body,
            string namespace_
        )
        {
            AdminDeleteBulkGameSessions op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminDeleteBulkGameSessions(op);
        }
        public static async Task<Session.Model.ApimodelsDeleteBulkGameSessionsAPIResponse?> ExecuteAsync(
            this AdminDeleteBulkGameSessions.AdminDeleteBulkGameSessionsBuilder builder,
            ApimodelsDeleteBulkGameSessionRequest body,
            string namespace_
        )
        {
            AdminDeleteBulkGameSessions op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminDeleteBulkGameSessionsAsync(op);
        }
        public static void Execute(
            this AdminSetDSReady.AdminSetDSReadyBuilder builder,
            ApimodelsSetDSReadyRequest body,
            string namespace_,
            string sessionId
        )
        {
            AdminSetDSReady op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminSetDSReady(op);
        }
        public static async Task ExecuteAsync(
            this AdminSetDSReady.AdminSetDSReadyBuilder builder,
            ApimodelsSetDSReadyRequest body,
            string namespace_,
            string sessionId
        )
        {
            AdminSetDSReady op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminSetDSReadyAsync(op);
        }
        public static void Execute(
            this AdminKickGameSessionMember.AdminKickGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId
        )
        {
            AdminKickGameSessionMember op = builder.Build(
                memberId,
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminKickGameSessionMember(op);
        }
        public static async Task ExecuteAsync(
            this AdminKickGameSessionMember.AdminKickGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId
        )
        {
            AdminKickGameSessionMember op = builder.Build(
                memberId,
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminKickGameSessionMemberAsync(op);
        }
        public static Session.Model.ApimodelsUpdateGameSessionMemberStatusResponse? Execute(
            this AdminUpdateGameSessionMember.AdminUpdateGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId,
            string statusType
        )
        {
            AdminUpdateGameSessionMember op = builder.Build(
                memberId,
                namespace_,
                sessionId,
                statusType
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminUpdateGameSessionMember(op);
        }
        public static async Task<Session.Model.ApimodelsUpdateGameSessionMemberStatusResponse?> ExecuteAsync(
            this AdminUpdateGameSessionMember.AdminUpdateGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId,
            string statusType
        )
        {
            AdminUpdateGameSessionMember op = builder.Build(
                memberId,
                namespace_,
                sessionId,
                statusType
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).AdminUpdateGameSessionMemberAsync(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this CreateGameSession.CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            CreateGameSession op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).CreateGameSession(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this CreateGameSession.CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            CreateGameSession op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).CreateGameSessionAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this CreateGameSession.CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            CreateGameSession op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).CreateGameSession<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this CreateGameSession.CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            CreateGameSession op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).CreateGameSessionAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionQueryResponse? Execute(
            this PublicQueryGameSessionsByAttributes.PublicQueryGameSessionsByAttributesBuilder builder,
            Dictionary<string, object> body,
            string namespace_
        )
        {
            PublicQueryGameSessionsByAttributes op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryGameSessionsByAttributes(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionQueryResponse?> ExecuteAsync(
            this PublicQueryGameSessionsByAttributes.PublicQueryGameSessionsByAttributesBuilder builder,
            Dictionary<string, object> body,
            string namespace_
        )
        {
            PublicQueryGameSessionsByAttributes op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryGameSessionsByAttributesAsync(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this PublicSessionJoinCode.PublicSessionJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PublicSessionJoinCode op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicSessionJoinCode(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this PublicSessionJoinCode.PublicSessionJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PublicSessionJoinCode op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicSessionJoinCodeAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this PublicSessionJoinCode.PublicSessionJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PublicSessionJoinCode op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicSessionJoinCode<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this PublicSessionJoinCode.PublicSessionJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PublicSessionJoinCode op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicSessionJoinCodeAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this GetGameSessionByPodName.GetGameSessionByPodNameBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetGameSessionByPodName op = builder.Build(
                namespace_,
                podName
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionByPodName(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this GetGameSessionByPodName.GetGameSessionByPodNameBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetGameSessionByPodName op = builder.Build(
                namespace_,
                podName
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionByPodNameAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this GetGameSessionByPodName.GetGameSessionByPodNameBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetGameSessionByPodName op = builder.Build(
                namespace_,
                podName
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionByPodName<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this GetGameSessionByPodName.GetGameSessionByPodNameBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetGameSessionByPodName op = builder.Build(
                namespace_,
                podName
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionByPodNameAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this GetGameSession.GetGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSession(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this GetGameSession.GetGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this GetGameSession.GetGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSession<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this GetGameSession.GetGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this UpdateGameSession.UpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSession(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this UpdateGameSession.UpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this UpdateGameSession.UpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSession<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this UpdateGameSession.UpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionAsync<T1, T2>(op);
        }
        public static void Execute(
            this DeleteGameSession.DeleteGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            DeleteGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).DeleteGameSession(op);
        }
        public static async Task ExecuteAsync(
            this DeleteGameSession.DeleteGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            DeleteGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).DeleteGameSessionAsync(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this PatchUpdateGameSession.PatchUpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            PatchUpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PatchUpdateGameSession(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this PatchUpdateGameSession.PatchUpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            PatchUpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PatchUpdateGameSessionAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this PatchUpdateGameSession.PatchUpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            PatchUpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PatchUpdateGameSession<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this PatchUpdateGameSession.PatchUpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            PatchUpdateGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PatchUpdateGameSessionAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this UpdateGameSessionBackfillTicketID.UpdateGameSessionBackfillTicketIDBuilder builder,
            ApimodelsUpdateGameSessionBackfillRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSessionBackfillTicketID op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionBackfillTicketID(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this UpdateGameSessionBackfillTicketID.UpdateGameSessionBackfillTicketIDBuilder builder,
            ApimodelsUpdateGameSessionBackfillRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSessionBackfillTicketID op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionBackfillTicketIDAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this UpdateGameSessionBackfillTicketID.UpdateGameSessionBackfillTicketIDBuilder builder,
            ApimodelsUpdateGameSessionBackfillRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSessionBackfillTicketID op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionBackfillTicketID<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this UpdateGameSessionBackfillTicketID.UpdateGameSessionBackfillTicketIDBuilder builder,
            ApimodelsUpdateGameSessionBackfillRequest body,
            string namespace_,
            string sessionId
        )
        {
            UpdateGameSessionBackfillTicketID op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionBackfillTicketIDAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this GameSessionGenerateCode.GameSessionGenerateCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GameSessionGenerateCode op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GameSessionGenerateCode(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this GameSessionGenerateCode.GameSessionGenerateCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GameSessionGenerateCode op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GameSessionGenerateCodeAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this GameSessionGenerateCode.GameSessionGenerateCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GameSessionGenerateCode op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GameSessionGenerateCode<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this GameSessionGenerateCode.GameSessionGenerateCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GameSessionGenerateCode op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GameSessionGenerateCodeAsync<T1, T2>(op);
        }
        public static void Execute(
            this PublicRevokeGameSessionCode.PublicRevokeGameSessionCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PublicRevokeGameSessionCode op = builder.Build(
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicRevokeGameSessionCode(op);
        }
        public static async Task ExecuteAsync(
            this PublicRevokeGameSessionCode.PublicRevokeGameSessionCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PublicRevokeGameSessionCode op = builder.Build(
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicRevokeGameSessionCodeAsync(op);
        }
        public static void Execute(
            this PublicGameSessionInvite.PublicGameSessionInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
            string namespace_,
            string sessionId
        )
        {
            PublicGameSessionInvite op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicGameSessionInvite(op);
        }
        public static async Task ExecuteAsync(
            this PublicGameSessionInvite.PublicGameSessionInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
            string namespace_,
            string sessionId
        )
        {
            PublicGameSessionInvite op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicGameSessionInviteAsync(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this JoinGameSession.JoinGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            JoinGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).JoinGameSession(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this JoinGameSession.JoinGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            JoinGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).JoinGameSessionAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this JoinGameSession.JoinGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            JoinGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).JoinGameSession<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this JoinGameSession.JoinGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            JoinGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).JoinGameSessionAsync<T1, T2>(op);
        }
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this PublicPromoteGameSessionLeader.PublicPromoteGameSessionLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
            string namespace_,
            string sessionId
        )
        {
            PublicPromoteGameSessionLeader op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicPromoteGameSessionLeader(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this PublicPromoteGameSessionLeader.PublicPromoteGameSessionLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
            string namespace_,
            string sessionId
        )
        {
            PublicPromoteGameSessionLeader op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicPromoteGameSessionLeaderAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this PublicPromoteGameSessionLeader.PublicPromoteGameSessionLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
            string namespace_,
            string sessionId
        )
        {
            PublicPromoteGameSessionLeader op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicPromoteGameSessionLeader<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this PublicPromoteGameSessionLeader.PublicPromoteGameSessionLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
            string namespace_,
            string sessionId
        )
        {
            PublicPromoteGameSessionLeader op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicPromoteGameSessionLeaderAsync<T1, T2>(op);
        }
        public static void Execute(
            this LeaveGameSession.LeaveGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            LeaveGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).LeaveGameSession(op);
        }
        public static async Task ExecuteAsync(
            this LeaveGameSession.LeaveGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            LeaveGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).LeaveGameSessionAsync(op);
        }
        public static void Execute(
            this PublicKickGameSessionMember.PublicKickGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId
        )
        {
            PublicKickGameSessionMember op = builder.Build(
                memberId,
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicKickGameSessionMember(op);
        }
        public static async Task ExecuteAsync(
            this PublicKickGameSessionMember.PublicKickGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId
        )
        {
            PublicKickGameSessionMember op = builder.Build(
                memberId,
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicKickGameSessionMemberAsync(op);
        }
        public static void Execute(
            this PublicGameSessionReject.PublicGameSessionRejectBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PublicGameSessionReject op = builder.Build(
                namespace_,
                sessionId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicGameSessionReject(op);
        }
        public static async Task ExecuteAsync(
            this PublicGameSessionReject.PublicGameSessionRejectBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PublicGameSessionReject op = builder.Build(
                namespace_,
                sessionId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicGameSessionRejectAsync(op);
        }
        public static Session.Model.ApimodelsServerSecret? Execute(
            this GetSessionServerSecret.GetSessionServerSecretBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetSessionServerSecret op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetSessionServerSecret(op);
        }
        public static async Task<Session.Model.ApimodelsServerSecret?> ExecuteAsync(
            this GetSessionServerSecret.GetSessionServerSecretBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetSessionServerSecret op = builder.Build(
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).GetSessionServerSecretAsync(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Session.Model.ApimodelsGameSessionResponse? Execute(
            this AppendTeamGameSession.AppendTeamGameSessionBuilder builder,
            ApimodelsAppendTeamGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            AppendTeamGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).AppendTeamGameSession(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse?> ExecuteAsync(
            this AppendTeamGameSession.AppendTeamGameSessionBuilder builder,
            ApimodelsAppendTeamGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            AppendTeamGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).AppendTeamGameSessionAsync(op);
        }

        public static Session.Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
            this AppendTeamGameSession.AppendTeamGameSessionBuilder builder,
            ApimodelsAppendTeamGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            AppendTeamGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).AppendTeamGameSession<T1, T2>(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
            this AppendTeamGameSession.AppendTeamGameSessionBuilder builder,
            ApimodelsAppendTeamGameSessionRequest body,
            string namespace_,
            string sessionId
        )
        {
            AppendTeamGameSession op = builder.Build(
                body,
                namespace_,
                sessionId
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).AppendTeamGameSessionAsync<T1, T2>(op);
        }
        public static void Execute(
            this PublicGameSessionCancel.PublicGameSessionCancelBuilder builder,
            string namespace_,
            string sessionId,
            string userId
        )
        {
            PublicGameSessionCancel op = builder.Build(
                namespace_,
                sessionId,
                userId
            );

            ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicGameSessionCancel(op);
        }
        public static async Task ExecuteAsync(
            this PublicGameSessionCancel.PublicGameSessionCancelBuilder builder,
            string namespace_,
            string sessionId,
            string userId
        )
        {
            PublicGameSessionCancel op = builder.Build(
                namespace_,
                sessionId,
                userId
            );

            await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicGameSessionCancelAsync(op);
        }
        public static Session.Model.ApimodelsGameSessionQueryResponse? Execute(
            this PublicQueryMyGameSessions.PublicQueryMyGameSessionsBuilder builder,
            string namespace_
        )
        {
            PublicQueryMyGameSessions op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryMyGameSessions(op);
        }
        public static async Task<Session.Model.ApimodelsGameSessionQueryResponse?> ExecuteAsync(
            this PublicQueryMyGameSessions.PublicQueryMyGameSessionsBuilder builder,
            string namespace_
        )
        {
            PublicQueryMyGameSessions op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryMyGameSessionsAsync(op);
        }
    }
}