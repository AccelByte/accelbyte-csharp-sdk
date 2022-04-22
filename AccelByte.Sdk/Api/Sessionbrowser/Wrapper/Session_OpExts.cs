// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;
using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionbrowserSession_OpExts
    {
        public static Sessionbrowser.Model.ModelsCountActiveSessionResponse? Execute(
            this GetTotalActiveSession.GetTotalActiveSessionBuilder builder,
            string namespace_
        )
        {
            GetTotalActiveSession op = builder.Build(
                namespace_
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetTotalActiveSession(op);
        }

        public static Sessionbrowser.Model.ModelsActiveCustomGameResponse? Execute(
            this GetActiveCustomGameSessions.GetActiveCustomGameSessionsBuilder builder,
            string namespace_
        )
        {
            GetActiveCustomGameSessions op = builder.Build(
                namespace_
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetActiveCustomGameSessions(op);
        }

        public static Sessionbrowser.Model.ModelsActiveMatchmakingGameResponse? Execute(
            this GetActiveMatchmakingGameSessions.GetActiveMatchmakingGameSessionsBuilder builder,
            string namespace_
        )
        {
            GetActiveMatchmakingGameSessions op = builder.Build(
                namespace_
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetActiveMatchmakingGameSessions(op);
        }

        public static Sessionbrowser.Model.ModelsAdminSessionResponse? Execute(
            this AdminGetSession.AdminGetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            AdminGetSession op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminGetSession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionQueryResponse? Execute(
            this QuerySession.QuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            QuerySession op = builder.Build(
                namespace_,
                sessionType
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).QuerySession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this CreateSession.CreateSessionBuilder builder,
            ModelsCreateSessionRequest body,
            string namespace_
        )
        {
            CreateSession op = builder.Build(
                body,
                namespace_
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).CreateSession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionByUserIDsResponse? Execute(
            this GetSessionByUserIDs.GetSessionByUserIDsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            GetSessionByUserIDs op = builder.Build(
                namespace_,
                userIds
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetSessionByUserIDs(op);
        }

        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this GetSession.GetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            GetSession op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetSession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this UpdateSession.UpdateSessionBuilder builder,
            ModelsUpdateSessionRequest body,
            string namespace_,
            string sessionID
        )
        {
            UpdateSession op = builder.Build(
                body,
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).UpdateSession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this DeleteSession.DeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            DeleteSession op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).DeleteSession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this JoinSession.JoinSessionBuilder builder,
            ModelsJoinGameSessionRequest body,
            string namespace_,
            string sessionID
        )
        {
            JoinSession op = builder.Build(
                body,
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).JoinSession(op);
        }

        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this DeleteSessionLocalDS.DeleteSessionLocalDSBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            DeleteSessionLocalDS op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).DeleteSessionLocalDS(op);
        }

        public static Sessionbrowser.Model.ModelsAddPlayerResponse? Execute(
            this AddPlayerToSession.AddPlayerToSessionBuilder builder,
            ModelsAddPlayerRequest body,
            string namespace_,
            string sessionID
        )
        {
            AddPlayerToSession op = builder.Build(
                body,
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AddPlayerToSession(op);
        }

        public static Sessionbrowser.Model.ModelsAddPlayerResponse? Execute(
            this RemovePlayerFromSession.RemovePlayerFromSessionBuilder builder,
            string namespace_,
            string sessionID,
            string userID
        )
        {
            RemovePlayerFromSession op = builder.Build(
                namespace_,
                sessionID,
                userID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).RemovePlayerFromSession(op);
        }

        public static Sessionbrowser.Model.ModelsRecentPlayerQueryResponse? Execute(
            this GetRecentPlayer.GetRecentPlayerBuilder builder,
            string namespace_,
            string userID
        )
        {
            GetRecentPlayer op = builder.Build(
                namespace_,
                userID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetRecentPlayer(op);
        }

    }
}