// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Sessionbrowser.Wrapper
{
    public class Session
    {
        private readonly AccelByteSDK _sdk;

        public Session(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetTotalActiveSession.GetTotalActiveSessionBuilder GetTotalActiveSessionOp
        {
            get { return Operation.GetTotalActiveSession.Builder.SetWrapperObject(this); }
        }
        public GetActiveCustomGameSessions.GetActiveCustomGameSessionsBuilder GetActiveCustomGameSessionsOp
        {
            get { return Operation.GetActiveCustomGameSessions.Builder.SetWrapperObject(this); }
        }
        public GetActiveMatchmakingGameSessions.GetActiveMatchmakingGameSessionsBuilder GetActiveMatchmakingGameSessionsOp
        {
            get { return Operation.GetActiveMatchmakingGameSessions.Builder.SetWrapperObject(this); }
        }
        public AdminGetSession.AdminGetSessionBuilder AdminGetSessionOp
        {
            get { return Operation.AdminGetSession.Builder.SetWrapperObject(this); }
        }
        public QuerySession.QuerySessionBuilder QuerySessionOp
        {
            get { return Operation.QuerySession.Builder.SetWrapperObject(this); }
        }
        public CreateSession.CreateSessionBuilder CreateSessionOp
        {
            get { return Operation.CreateSession.Builder.SetWrapperObject(this); }
        }
        public GetSessionByUserIDs.GetSessionByUserIDsBuilder GetSessionByUserIDsOp
        {
            get { return Operation.GetSessionByUserIDs.Builder.SetWrapperObject(this); }
        }
        public GetSession.GetSessionBuilder GetSessionOp
        {
            get { return Operation.GetSession.Builder.SetWrapperObject(this); }
        }
        public UpdateSession.UpdateSessionBuilder UpdateSessionOp
        {
            get { return Operation.UpdateSession.Builder.SetWrapperObject(this); }
        }
        public DeleteSession.DeleteSessionBuilder DeleteSessionOp
        {
            get { return Operation.DeleteSession.Builder.SetWrapperObject(this); }
        }
        public JoinSession.JoinSessionBuilder JoinSessionOp
        {
            get { return Operation.JoinSession.Builder.SetWrapperObject(this); }
        }
        public DeleteSessionLocalDS.DeleteSessionLocalDSBuilder DeleteSessionLocalDSOp
        {
            get { return Operation.DeleteSessionLocalDS.Builder.SetWrapperObject(this); }
        }
        public AddPlayerToSession.AddPlayerToSessionBuilder AddPlayerToSessionOp
        {
            get { return Operation.AddPlayerToSession.Builder.SetWrapperObject(this); }
        }
        public RemovePlayerFromSession.RemovePlayerFromSessionBuilder RemovePlayerFromSessionOp
        {
            get { return Operation.RemovePlayerFromSession.Builder.SetWrapperObject(this); }
        }
        public GetRecentPlayer.GetRecentPlayerBuilder GetRecentPlayerOp
        {
            get { return Operation.GetRecentPlayer.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsCountActiveSessionResponse? GetTotalActiveSession(GetTotalActiveSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsActiveCustomGameResponse? GetActiveCustomGameSessions(GetActiveCustomGameSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsActiveMatchmakingGameResponse? GetActiveMatchmakingGameSessions(GetActiveMatchmakingGameSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminSessionResponse? AdminGetSession(AdminGetSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionQueryResponse? QuerySession(QuerySession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? CreateSession(CreateSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionByUserIDsResponse? GetSessionByUserIDs(GetSessionByUserIDs input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? GetSession(GetSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? UpdateSession(UpdateSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? DeleteSession(DeleteSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? JoinSession(JoinSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? DeleteSessionLocalDS(DeleteSessionLocalDS input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAddPlayerResponse? AddPlayerToSession(AddPlayerToSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAddPlayerResponse? RemovePlayerFromSession(RemovePlayerFromSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRecentPlayerQueryResponse? GetRecentPlayer(GetRecentPlayer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}