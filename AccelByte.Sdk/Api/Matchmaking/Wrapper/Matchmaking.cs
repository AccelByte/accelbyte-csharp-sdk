// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class Matchmaking
    {
        private readonly AccelByteSDK _sdk;

        public Matchmaking(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAllChannelsHandler.GetAllChannelsHandlerBuilder GetAllChannelsHandlerOp
        {
            get { return Operation.GetAllChannelsHandler.Builder.SetWrapperObject(this); }
        }
        public CreateChannelHandler.CreateChannelHandlerBuilder CreateChannelHandlerOp
        {
            get { return Operation.CreateChannelHandler.Builder.SetWrapperObject(this); }
        }
        public DeleteChannelHandler.DeleteChannelHandlerBuilder DeleteChannelHandlerOp
        {
            get { return Operation.DeleteChannelHandler.Builder.SetWrapperObject(this); }
        }
        public StoreMatchResults.StoreMatchResultsBuilder StoreMatchResultsOp
        {
            get { return Operation.StoreMatchResults.Builder.SetWrapperObject(this); }
        }
        public Rebalance.RebalanceBuilder RebalanceOp
        {
            get { return Operation.Rebalance.Builder.SetWrapperObject(this); }
        }
        public QueueSessionHandler.QueueSessionHandlerBuilder QueueSessionHandlerOp
        {
            get { return Operation.QueueSessionHandler.Builder.SetWrapperObject(this); }
        }
        public DequeueSessionHandler.DequeueSessionHandlerBuilder DequeueSessionHandlerOp
        {
            get { return Operation.DequeueSessionHandler.Builder.SetWrapperObject(this); }
        }
        public QuerySessionHandler.QuerySessionHandlerBuilder QuerySessionHandlerOp
        {
            get { return Operation.QuerySessionHandler.Builder.SetWrapperObject(this); }
        }
        public GetAllPartyInAllChannel.GetAllPartyInAllChannelBuilder GetAllPartyInAllChannelOp
        {
            get { return Operation.GetAllPartyInAllChannel.Builder.SetWrapperObject(this); }
        }
        public BulkGetSessions.BulkGetSessionsBuilder BulkGetSessionsOp
        {
            get { return Operation.BulkGetSessions.Builder.SetWrapperObject(this); }
        }
        public ExportChannels.ExportChannelsBuilder ExportChannelsOp
        {
            get { return Operation.ExportChannels.Builder.SetWrapperObject(this); }
        }
        public ImportChannels.ImportChannelsBuilder ImportChannelsOp
        {
            get { return Operation.ImportChannels.Builder.SetWrapperObject(this); }
        }
        public GetSingleMatchmakingChannel.GetSingleMatchmakingChannelBuilder GetSingleMatchmakingChannelOp
        {
            get { return Operation.GetSingleMatchmakingChannel.Builder.SetWrapperObject(this); }
        }
        public UpdateMatchmakingChannel.UpdateMatchmakingChannelBuilder UpdateMatchmakingChannelOp
        {
            get { return Operation.UpdateMatchmakingChannel.Builder.SetWrapperObject(this); }
        }
        public GetAllPartyInChannel.GetAllPartyInChannelBuilder GetAllPartyInChannelOp
        {
            get { return Operation.GetAllPartyInChannel.Builder.SetWrapperObject(this); }
        }
        public GetAllSessionsInChannel.GetAllSessionsInChannelBuilder GetAllSessionsInChannelOp
        {
            get { return Operation.GetAllSessionsInChannel.Builder.SetWrapperObject(this); }
        }
        public AddUserIntoSessionInChannel.AddUserIntoSessionInChannelBuilder AddUserIntoSessionInChannelOp
        {
            get { return Operation.AddUserIntoSessionInChannel.Builder.SetWrapperObject(this); }
        }
        public DeleteSessionInChannel.DeleteSessionInChannelBuilder DeleteSessionInChannelOp
        {
            get { return Operation.DeleteSessionInChannel.Builder.SetWrapperObject(this); }
        }
        public DeleteUserFromSessionInChannel.DeleteUserFromSessionInChannelBuilder DeleteUserFromSessionInChannelOp
        {
            get { return Operation.DeleteUserFromSessionInChannel.Builder.SetWrapperObject(this); }
        }
        public SearchSessions.SearchSessionsBuilder SearchSessionsOp
        {
            get { return Operation.SearchSessions.Builder.SetWrapperObject(this); }
        }
        public GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder GetSessionHistoryDetailedOp
        {
            get { return Operation.GetSessionHistoryDetailed.Builder.SetWrapperObject(this); }
        }
        public PublicGetAllMatchmakingChannel.PublicGetAllMatchmakingChannelBuilder PublicGetAllMatchmakingChannelOp
        {
            get { return Operation.PublicGetAllMatchmakingChannel.Builder.SetWrapperObject(this); }
        }
        public PublicGetSingleMatchmakingChannel.PublicGetSingleMatchmakingChannelBuilder PublicGetSingleMatchmakingChannelOp
        {
            get { return Operation.PublicGetSingleMatchmakingChannel.Builder.SetWrapperObject(this); }
        }
        public SearchSessionsV2.SearchSessionsV2Builder SearchSessionsV2Op
        {
            get { return Operation.SearchSessionsV2.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetChannelsResponse? GetAllChannelsHandler(GetAllChannelsHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateChannelResponse? CreateChannelHandler(CreateChannelHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteChannelHandler(DeleteChannelHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMatchResultResponse? StoreMatchResults(StoreMatchResults input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRebalanceResponse? Rebalance(Rebalance input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void QueueSessionHandler(QueueSessionHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DequeueSessionHandler(DequeueSessionHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMatchmakingResult? QuerySessionHandler(QuerySessionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetAllPartyInAllChannel(GetAllPartyInAllChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsMatchmakingResult>? BulkGetSessions(BulkGetSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChannelV1>? ExportChannels(ExportChannels input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsImportConfigResponse? ImportChannels(ImportChannels input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelV1? GetSingleMatchmakingChannel(GetSingleMatchmakingChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateMatchmakingChannel(UpdateMatchmakingChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsMatchingParty>? GetAllPartyInChannel(GetAllPartyInChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsMatchmakingResult>? GetAllSessionsInChannel(GetAllSessionsInChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddUserIntoSessionInChannel(AddUserIntoSessionInChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSessionInChannel(DeleteSessionInChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserFromSessionInChannel(DeleteUserFromSessionInChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ServiceGetSessionHistorySearchResponse? SearchSessions(SearchSessions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ServiceGetSessionHistoryDetailedResponseItem>? GetSessionHistoryDetailed(GetSessionHistoryDetailed input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChannelV1>? PublicGetAllMatchmakingChannel(PublicGetAllMatchmakingChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelV1? PublicGetSingleMatchmakingChannel(PublicGetSingleMatchmakingChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ServiceGetSessionHistorySearchResponseV2? SearchSessionsV2(SearchSessionsV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}