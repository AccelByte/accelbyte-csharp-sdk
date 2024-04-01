// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;
using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionbrowserSession_OpExts
    {
        public static Sessionbrowser.Model.ModelsSessionQueryResponse? Execute(
            this AdminQuerySession.AdminQuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            AdminQuerySession op = builder.Build(
                namespace_,
                sessionType
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminQuerySession(op);
        }
        public static async Task<Sessionbrowser.Model.ModelsSessionQueryResponse?> ExecuteAsync(
            this AdminQuerySession.AdminQuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            AdminQuerySession op = builder.Build(
                namespace_,
                sessionType
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminQuerySessionAsync(op);
        }
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
        public static async Task<Sessionbrowser.Model.ModelsCountActiveSessionResponse?> ExecuteAsync(
            this GetTotalActiveSession.GetTotalActiveSessionBuilder builder,
            string namespace_
        )
        {
            GetTotalActiveSession op = builder.Build(
                namespace_
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetTotalActiveSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsActiveCustomGameResponse?> ExecuteAsync(
            this GetActiveCustomGameSessions.GetActiveCustomGameSessionsBuilder builder,
            string namespace_
        )
        {
            GetActiveCustomGameSessions op = builder.Build(
                namespace_
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetActiveCustomGameSessionsAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsActiveMatchmakingGameResponse?> ExecuteAsync(
            this GetActiveMatchmakingGameSessions.GetActiveMatchmakingGameSessionsBuilder builder,
            string namespace_
        )
        {
            GetActiveMatchmakingGameSessions op = builder.Build(
                namespace_
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetActiveMatchmakingGameSessionsAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsAdminSessionResponse?> ExecuteAsync(
            this AdminGetSession.AdminGetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            AdminGetSession op = builder.Build(
                namespace_,
                sessionID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminGetSessionAsync(op);
        }
        public static Sessionbrowser.Model.ModelsAdminSessionResponse? Execute(
            this AdminDeleteSession.AdminDeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            AdminDeleteSession op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminDeleteSession(op);
        }
        public static async Task<Sessionbrowser.Model.ModelsAdminSessionResponse?> ExecuteAsync(
            this AdminDeleteSession.AdminDeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            AdminDeleteSession op = builder.Build(
                namespace_,
                sessionID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminDeleteSessionAsync(op);
        }
        public static Sessionbrowser.Model.ModelsGetSessionHistorySearchResponseV2? Execute(
            this AdminSearchSessionsV2.AdminSearchSessionsV2Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            AdminSearchSessionsV2 op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminSearchSessionsV2(op);
        }
        public static async Task<Sessionbrowser.Model.ModelsGetSessionHistorySearchResponseV2?> ExecuteAsync(
            this AdminSearchSessionsV2.AdminSearchSessionsV2Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            AdminSearchSessionsV2 op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AdminSearchSessionsV2Async(op);
        }
        public static List<Sessionbrowser.Model.ModelsGetSessionHistoryDetailedResponseItem>? Execute(
            this GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            GetSessionHistoryDetailed op = builder.Build(
                matchID,
                namespace_
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetSessionHistoryDetailed(op);
        }
        public static async Task<List<Sessionbrowser.Model.ModelsGetSessionHistoryDetailedResponseItem>?> ExecuteAsync(
            this GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            GetSessionHistoryDetailed op = builder.Build(
                matchID,
                namespace_
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetSessionHistoryDetailedAsync(op);
        }
        public static Sessionbrowser.Model.ModelsSessionQueryResponse? Execute(
            this UserQuerySession.UserQuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            UserQuerySession op = builder.Build(
                namespace_,
                sessionType
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).UserQuerySession(op);
        }
        public static async Task<Sessionbrowser.Model.ModelsSessionQueryResponse?> ExecuteAsync(
            this UserQuerySession.UserQuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            UserQuerySession op = builder.Build(
                namespace_,
                sessionType
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).UserQuerySessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
            this CreateSession.CreateSessionBuilder builder,
            ModelsCreateSessionRequest body,
            string namespace_
        )
        {
            CreateSession op = builder.Build(
                body,
                namespace_
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).CreateSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionByUserIDsResponse?> ExecuteAsync(
            this GetSessionByUserIDs.GetSessionByUserIDsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            GetSessionByUserIDs op = builder.Build(
                namespace_,
                userIds
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetSessionByUserIDsAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
            this GetSession.GetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            GetSession op = builder.Build(
                namespace_,
                sessionID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
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

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).UpdateSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
            this DeleteSession.DeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            DeleteSession op = builder.Build(
                namespace_,
                sessionID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).DeleteSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
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

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).JoinSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
            this DeleteSessionLocalDS.DeleteSessionLocalDSBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            DeleteSessionLocalDS op = builder.Build(
                namespace_,
                sessionID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).DeleteSessionLocalDSAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsAddPlayerResponse?> ExecuteAsync(
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

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).AddPlayerToSessionAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsAddPlayerResponse?> ExecuteAsync(
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

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).RemovePlayerFromSessionAsync(op);
        }
        public static Sessionbrowser.Model.ModelsSessionResponse? Execute(
            this UpdateSettings.UpdateSettingsBuilder builder,
            ModelsUpdateSettingsRequest body,
            string namespace_,
            string sessionID
        )
        {
            UpdateSettings op = builder.Build(
                body,
                namespace_,
                sessionID
            );

            return ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).UpdateSettings(op);
        }
        public static async Task<Sessionbrowser.Model.ModelsSessionResponse?> ExecuteAsync(
            this UpdateSettings.UpdateSettingsBuilder builder,
            ModelsUpdateSettingsRequest body,
            string namespace_,
            string sessionID
        )
        {
            UpdateSettings op = builder.Build(
                body,
                namespace_,
                sessionID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).UpdateSettingsAsync(op);
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
        public static async Task<Sessionbrowser.Model.ModelsRecentPlayerQueryResponse?> ExecuteAsync(
            this GetRecentPlayer.GetRecentPlayerBuilder builder,
            string namespace_,
            string userID
        )
        {
            GetRecentPlayer op = builder.Build(
                namespace_,
                userID
            );

            return await ((Sessionbrowser.Wrapper.Session)builder.WrapperObject!).GetRecentPlayerAsync(op);
        }
    }
}