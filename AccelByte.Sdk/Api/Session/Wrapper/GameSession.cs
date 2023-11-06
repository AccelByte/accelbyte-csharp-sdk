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
        public AdminQueryGameSessionsByAttributes.AdminQueryGameSessionsByAttributesBuilder AdminQueryGameSessionsByAttributesOp
        {
            get { return Operation.AdminQueryGameSessionsByAttributes.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteBulkGameSessions.AdminDeleteBulkGameSessionsBuilder AdminDeleteBulkGameSessionsOp
        {
            get { return Operation.AdminDeleteBulkGameSessions.Builder.SetWrapperObject(this); }
        }
        public AdminSetDSReady.AdminSetDSReadyBuilder AdminSetDSReadyOp
        {
            get { return Operation.AdminSetDSReady.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateGameSessionMember.AdminUpdateGameSessionMemberBuilder AdminUpdateGameSessionMemberOp
        {
            get { return Operation.AdminUpdateGameSessionMember.Builder.SetWrapperObject(this); }
        }
        public CreateGameSession.CreateGameSessionBuilder CreateGameSessionOp
        {
            get { return Operation.CreateGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicQueryGameSessionsByAttributes.PublicQueryGameSessionsByAttributesBuilder PublicQueryGameSessionsByAttributesOp
        {
            get { return Operation.PublicQueryGameSessionsByAttributes.Builder.SetWrapperObject(this); }
        }
        public PublicSessionJoinCode.PublicSessionJoinCodeBuilder PublicSessionJoinCodeOp
        {
            get { return Operation.PublicSessionJoinCode.Builder.SetWrapperObject(this); }
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
        public UpdateGameSessionBackfillTicketID.UpdateGameSessionBackfillTicketIDBuilder UpdateGameSessionBackfillTicketIDOp
        {
            get { return Operation.UpdateGameSessionBackfillTicketID.Builder.SetWrapperObject(this); }
        }
        public GameSessionGenerateCode.GameSessionGenerateCodeBuilder GameSessionGenerateCodeOp
        {
            get { return Operation.GameSessionGenerateCode.Builder.SetWrapperObject(this); }
        }
        public PublicRevokeGameSessionCode.PublicRevokeGameSessionCodeBuilder PublicRevokeGameSessionCodeOp
        {
            get { return Operation.PublicRevokeGameSessionCode.Builder.SetWrapperObject(this); }
        }
        public PublicGameSessionInvite.PublicGameSessionInviteBuilder PublicGameSessionInviteOp
        {
            get { return Operation.PublicGameSessionInvite.Builder.SetWrapperObject(this); }
        }
        public JoinGameSession.JoinGameSessionBuilder JoinGameSessionOp
        {
            get { return Operation.JoinGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicPromoteGameSessionLeader.PublicPromoteGameSessionLeaderBuilder PublicPromoteGameSessionLeaderOp
        {
            get { return Operation.PublicPromoteGameSessionLeader.Builder.SetWrapperObject(this); }
        }
        public LeaveGameSession.LeaveGameSessionBuilder LeaveGameSessionOp
        {
            get { return Operation.LeaveGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicGameSessionReject.PublicGameSessionRejectBuilder PublicGameSessionRejectOp
        {
            get { return Operation.PublicGameSessionReject.Builder.SetWrapperObject(this); }
        }
        public AppendTeamGameSession.AppendTeamGameSessionBuilder AppendTeamGameSessionOp
        {
            get { return Operation.AppendTeamGameSession.Builder.SetWrapperObject(this); }
        }
        public PublicQueryMyGameSessions.PublicQueryMyGameSessionsBuilder PublicQueryMyGameSessionsOp
        {
            get { return Operation.PublicQueryMyGameSessions.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsGameSessionQueryResponse? AdminQueryGameSessions(AdminQueryGameSessions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionQueryResponse? AdminQueryGameSessionsByAttributes(AdminQueryGameSessionsByAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsDeleteBulkGameSessionsAPIResponse? AdminDeleteBulkGameSessions(AdminDeleteBulkGameSessions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSetDSReady(AdminSetDSReady input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsUpdateGameSessionMemberStatusResponse? AdminUpdateGameSessionMember(AdminUpdateGameSessionMember input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? CreateGameSession(CreateGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? CreateGameSession<T1, T2>(CreateGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionQueryResponse? PublicQueryGameSessionsByAttributes(PublicQueryGameSessionsByAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? PublicSessionJoinCode(PublicSessionJoinCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? PublicSessionJoinCode<T1, T2>(PublicSessionJoinCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? GetGameSessionByPodName(GetGameSessionByPodName input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? GetGameSessionByPodName<T1, T2>(GetGameSessionByPodName input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? GetGameSession(GetGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? GetGameSession<T1, T2>(GetGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? UpdateGameSession(UpdateGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? UpdateGameSession<T1, T2>(UpdateGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGameSession(DeleteGameSession input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? PatchUpdateGameSession(PatchUpdateGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? PatchUpdateGameSession<T1, T2>(PatchUpdateGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? UpdateGameSessionBackfillTicketID(UpdateGameSessionBackfillTicketID input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? UpdateGameSessionBackfillTicketID<T1, T2>(UpdateGameSessionBackfillTicketID input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? GameSessionGenerateCode(GameSessionGenerateCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? GameSessionGenerateCode<T1, T2>(GameSessionGenerateCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicRevokeGameSessionCode(PublicRevokeGameSessionCode input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicGameSessionInvite(PublicGameSessionInvite input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? JoinGameSession(JoinGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? JoinGameSession<T1, T2>(JoinGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? PublicPromoteGameSessionLeader(PublicPromoteGameSessionLeader input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? PublicPromoteGameSessionLeader<T1, T2>(PublicPromoteGameSessionLeader input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void LeaveGameSession(LeaveGameSession input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicGameSessionReject(PublicGameSessionReject input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionResponse? AppendTeamGameSession(AppendTeamGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? AppendTeamGameSession<T1, T2>(AppendTeamGameSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionQueryResponse? PublicQueryMyGameSessions(PublicQueryMyGameSessions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}