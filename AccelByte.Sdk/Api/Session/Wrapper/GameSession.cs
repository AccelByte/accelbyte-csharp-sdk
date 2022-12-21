// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class GameSession
    {
        private readonly AccelByteSDK _sdk;

        public GameSession(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryGameSessions.AdminQueryGameSessionsBuilder AdminQueryGameSessionsOp
        {
            get { return Operation.AdminQueryGameSessions.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateGameSessionMember.AdminUpdateGameSessionMemberBuilder AdminUpdateGameSessionMemberOp
        {
            get { return Operation.AdminUpdateGameSessionMember.Builder.SetWrapperObject(this); }
        }
        public CreateGameSession.CreateGameSessionBuilder CreateGameSessionOp
        {
            get { return Operation.CreateGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicQueryGameSessions.PublicQueryGameSessionsBuilder PublicQueryGameSessionsOp
        {
            get { return Operation.PublicQueryGameSessions.Builder.SetWrapperObject(this); }
        }
        public GetGameSessionByPodName.GetGameSessionByPodNameBuilder GetGameSessionByPodNameOp
        {
            get { return Operation.GetGameSessionByPodName.Builder.SetWrapperObject(this); }
        }
        public GetGameSession.GetGameSessionBuilder GetGameSessionOp
        {
            get { return Operation.GetGameSession.Builder.SetWrapperObject(this); }
        }
        public UpdateGameSession.UpdateGameSessionBuilder UpdateGameSessionOp
        {
            get { return Operation.UpdateGameSession.Builder.SetWrapperObject(this); }
        }
        public DeleteGameSession.DeleteGameSessionBuilder DeleteGameSessionOp
        {
            get { return Operation.DeleteGameSession.Builder.SetWrapperObject(this); }
        }
        public PatchUpdateGameSession.PatchUpdateGameSessionBuilder PatchUpdateGameSessionOp
        {
            get { return Operation.PatchUpdateGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicGameSessionInvite.PublicGameSessionInviteBuilder PublicGameSessionInviteOp
        {
            get { return Operation.PublicGameSessionInvite.Builder.SetWrapperObject(this); }
        }
        public JoinGameSession.JoinGameSessionBuilder JoinGameSessionOp
        {
            get { return Operation.JoinGameSession.Builder.SetWrapperObject(this); }
        }
        public LeaveGameSession.LeaveGameSessionBuilder LeaveGameSessionOp
        {
            get { return Operation.LeaveGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicGameSessionReject.PublicGameSessionRejectBuilder PublicGameSessionRejectOp
        {
            get { return Operation.PublicGameSessionReject.Builder.SetWrapperObject(this); }
        }
        public PublicQueryMyGameSessions.PublicQueryMyGameSessionsBuilder PublicQueryMyGameSessionsOp
        {
            get { return Operation.PublicQueryMyGameSessions.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ApimodelsGameSessionQueryResponse? AdminQueryGameSessions(AdminQueryGameSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsUpdateGameSessionMemberStatusResponse? AdminUpdateGameSessionMember(AdminUpdateGameSessionMember input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? CreateGameSession(CreateGameSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionQueryResponse? PublicQueryGameSessions(PublicQueryGameSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? GetGameSessionByPodName(GetGameSessionByPodName input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? GetGameSession(GetGameSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? UpdateGameSession(UpdateGameSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGameSession(DeleteGameSession input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? PatchUpdateGameSession(PatchUpdateGameSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicGameSessionInvite(PublicGameSessionInvite input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? JoinGameSession(JoinGameSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void LeaveGameSession(LeaveGameSession input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicGameSessionReject(PublicGameSessionReject input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsGameSessionResponse>? PublicQueryMyGameSessions(PublicQueryMyGameSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}