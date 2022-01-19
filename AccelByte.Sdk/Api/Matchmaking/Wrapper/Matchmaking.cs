using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class Matchmaking {
        private readonly AccelByteSDK _sdk;

        public Matchmaking(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsGetChannelsResponse? GetAllChannelsHandler(GetAllChannelsHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateChannelResponse? CreateChannelHandler(CreateChannelHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteChannelHandler(DeleteChannelHandler input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMatchResultResponse? StoreMatchResults(StoreMatchResults input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void QueueSessionHandler(QueueSessionHandler input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DequeueSessionHandler(DequeueSessionHandler input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMatchmakingResult? QuerySessionHandler(QuerySessionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<object, object>? GetAllPartyInAllChannel(GetAllPartyInAllChannel input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsMatchmakingResult>? BulkGetSessions(BulkGetSessions input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChannelV1>? ExportChannels(ExportChannels input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsImportConfigResponse? ImportChannels(ImportChannels input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelV1? GetSingleMatchmakingChannel(GetSingleMatchmakingChannel input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateMatchmakingChannel(UpdateMatchmakingChannel input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsMatchingParty>? GetAllPartyInChannel(GetAllPartyInChannel input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsMatchmakingResult>? GetAllSessionsInChannel(GetAllSessionsInChannel input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddUserIntoSessionInChannel(AddUserIntoSessionInChannel input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSessionInChannel(DeleteSessionInChannel input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserFromSessionInChannel(DeleteUserFromSessionInChannel input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ServiceGetSessionHistorySearchResponse? SearchSessions(SearchSessions input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ServiceGetSessionHistoryDetailedResponseItem>? GetSessionHistoryDetailed(GetSessionHistoryDetailed input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsChannelV1>? PublicGetAllMatchmakingChannel(PublicGetAllMatchmakingChannel input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelV1? PublicGetSingleMatchmakingChannel(PublicGetSingleMatchmakingChannel input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}