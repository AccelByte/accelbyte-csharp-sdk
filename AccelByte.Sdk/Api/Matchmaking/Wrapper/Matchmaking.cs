// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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

    public static class Matchmaking_OperationExtensions
    {
        public static Model.ModelsGetChannelsResponse? Execute(
            this GetAllChannelsHandler.GetAllChannelsHandlerBuilder builder,
            string namespace_
        )
        {
            GetAllChannelsHandler op = builder.Build(
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).GetAllChannelsHandler(op);
        }

        public static Model.ModelsCreateChannelResponse? Execute(
            this CreateChannelHandler.CreateChannelHandlerBuilder builder,
            ModelsChannelRequest body,
            string namespace_
        )
        {
            CreateChannelHandler op = builder.Build(
                body,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).CreateChannelHandler(op);
        }

        public static void Execute(
            this DeleteChannelHandler.DeleteChannelHandlerBuilder builder,
            string channel,
            string namespace_
        )
        {
            DeleteChannelHandler op = builder.Build(
                channel,
                namespace_
            );

            ((Matchmaking)builder.WrapperObject!).DeleteChannelHandler(op);
        }

        public static Model.ModelsMatchResultResponse? Execute(
            this StoreMatchResults.StoreMatchResultsBuilder builder,
            ModelsMatchResultRequest body,
            string namespace_
        )
        {
            StoreMatchResults op = builder.Build(
                body,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).StoreMatchResults(op);
        }

        public static void Execute(
            this QueueSessionHandler.QueueSessionHandlerBuilder builder,
            ModelsMatchmakingResult body,
            string namespace_
        )
        {
            QueueSessionHandler op = builder.Build(
                body,
                namespace_
            );

            ((Matchmaking)builder.WrapperObject!).QueueSessionHandler(op);
        }

        public static void Execute(
            this DequeueSessionHandler.DequeueSessionHandlerBuilder builder,
            ModelsDequeueRequest body,
            string namespace_
        )
        {
            DequeueSessionHandler op = builder.Build(
                body,
                namespace_
            );

            ((Matchmaking)builder.WrapperObject!).DequeueSessionHandler(op);
        }

        public static Model.ModelsMatchmakingResult? Execute(
            this QuerySessionHandler.QuerySessionHandlerBuilder builder,
            string matchID,
            string namespace_
        )
        {
            QuerySessionHandler op = builder.Build(
                matchID,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).QuerySessionHandler(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetAllPartyInAllChannel.GetAllPartyInAllChannelBuilder builder,
            string namespace_
        )
        {
            GetAllPartyInAllChannel op = builder.Build(
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).GetAllPartyInAllChannel(op);
        }

        public static List<Model.ModelsMatchmakingResult>? Execute(
            this BulkGetSessions.BulkGetSessionsBuilder builder,
            string namespace_
        )
        {
            BulkGetSessions op = builder.Build(
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).BulkGetSessions(op);
        }

        public static List<Model.ModelsChannelV1>? Execute(
            this ExportChannels.ExportChannelsBuilder builder,
            string namespace_
        )
        {
            ExportChannels op = builder.Build(
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).ExportChannels(op);
        }

        public static Model.ModelsImportConfigResponse? Execute(
            this ImportChannels.ImportChannelsBuilder builder,
            string namespace_
        )
        {
            ImportChannels op = builder.Build(
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).ImportChannels(op);
        }

        public static Model.ModelsChannelV1? Execute(
            this GetSingleMatchmakingChannel.GetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetSingleMatchmakingChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).GetSingleMatchmakingChannel(op);
        }

        public static void Execute(
            this UpdateMatchmakingChannel.UpdateMatchmakingChannelBuilder builder,
            ModelsUpdateChannelRequest body,
            string channelName,
            string namespace_
        )
        {
            UpdateMatchmakingChannel op = builder.Build(
                body,
                channelName,
                namespace_
            );

            ((Matchmaking)builder.WrapperObject!).UpdateMatchmakingChannel(op);
        }

        public static List<Model.ModelsMatchingParty>? Execute(
            this GetAllPartyInChannel.GetAllPartyInChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllPartyInChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).GetAllPartyInChannel(op);
        }

        public static List<Model.ModelsMatchmakingResult>? Execute(
            this GetAllSessionsInChannel.GetAllSessionsInChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            GetAllSessionsInChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).GetAllSessionsInChannel(op);
        }

        public static void Execute(
            this AddUserIntoSessionInChannel.AddUserIntoSessionInChannelBuilder builder,
            ModelsMatchAddUserIntoSessionRequest body,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            AddUserIntoSessionInChannel op = builder.Build(
                body,
                channelName,
                matchID,
                namespace_
            );

            ((Matchmaking)builder.WrapperObject!).AddUserIntoSessionInChannel(op);
        }

        public static void Execute(
            this DeleteSessionInChannel.DeleteSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            DeleteSessionInChannel op = builder.Build(
                channelName,
                matchID,
                namespace_
            );

            ((Matchmaking)builder.WrapperObject!).DeleteSessionInChannel(op);
        }

        public static void Execute(
            this DeleteUserFromSessionInChannel.DeleteUserFromSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_,
            string userID
        )
        {
            DeleteUserFromSessionInChannel op = builder.Build(
                channelName,
                matchID,
                namespace_,
                userID
            );

            ((Matchmaking)builder.WrapperObject!).DeleteUserFromSessionInChannel(op);
        }

        public static Model.ServiceGetSessionHistorySearchResponse? Execute(
            this SearchSessions.SearchSessionsBuilder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            SearchSessions op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((Matchmaking)builder.WrapperObject!).SearchSessions(op);
        }

        public static List<Model.ServiceGetSessionHistoryDetailedResponseItem>? Execute(
            this GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            GetSessionHistoryDetailed op = builder.Build(
                matchID,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).GetSessionHistoryDetailed(op);
        }

        public static List<Model.ModelsChannelV1>? Execute(
            this PublicGetAllMatchmakingChannel.PublicGetAllMatchmakingChannelBuilder builder,
            string namespace_
        )
        {
            PublicGetAllMatchmakingChannel op = builder.Build(
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).PublicGetAllMatchmakingChannel(op);
        }

        public static Model.ModelsChannelV1? Execute(
            this PublicGetSingleMatchmakingChannel.PublicGetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PublicGetSingleMatchmakingChannel op = builder.Build(
                channelName,
                namespace_
            );

            return ((Matchmaking)builder.WrapperObject!).PublicGetSingleMatchmakingChannel(op);
        }

        public static Model.ServiceGetSessionHistorySearchResponseV2? Execute(
            this SearchSessionsV2.SearchSessionsV2Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            SearchSessionsV2 op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((Matchmaking)builder.WrapperObject!).SearchSessionsV2(op);
        }

    }
}