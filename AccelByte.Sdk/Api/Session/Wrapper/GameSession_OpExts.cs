// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
            this CreateGameSession.CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            CreateGameSession op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).CreateGameSession<T1>(op);
        }
        public static Session.Model.ApimodelsGameSessionQueryResponse? Execute(
            this PublicQueryGameSessions.PublicQueryGameSessionsBuilder builder,
            Dictionary<string, object> body,
            string namespace_
        )
        {
            PublicQueryGameSessions op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryGameSessions(op);
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
            this GetGameSessionByPodName.GetGameSessionByPodNameBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetGameSessionByPodName op = builder.Build(
                namespace_,
                podName
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSessionByPodName<T1>(op);
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
            this GetGameSession.GetGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            GetGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).GetGameSession<T1>(op);
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
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

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSession<T1>(op);
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
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

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PatchUpdateGameSession<T1>(op);
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
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

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).UpdateGameSessionBackfillTicketID<T1>(op);
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

        public static Session.Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
            this JoinGameSession.JoinGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            JoinGameSession op = builder.Build(
                namespace_,
                sessionId
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).JoinGameSession<T1>(op);
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
        public static List<Session.Model.ApimodelsGameSessionResponse>? Execute(
            this PublicQueryMyGameSessions.PublicQueryMyGameSessionsBuilder builder,
            string namespace_
        )
        {
            PublicQueryMyGameSessions op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryMyGameSessions(op);
        }

        public static List<Session.Model.ApimodelsGameSessionResponse<T1>>? Execute<T1>(
            this PublicQueryMyGameSessions.PublicQueryMyGameSessionsBuilder builder,
            string namespace_
        )
        {
            PublicQueryMyGameSessions op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.GameSession)builder.WrapperObject!).PublicQueryMyGameSessions<T1>(op);
        }
    }
}