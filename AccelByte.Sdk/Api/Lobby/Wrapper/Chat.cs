using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Chat {
        private readonly AccelByteSDK _sdk;

        public Chat(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.ModelChatMessageResponse>? PersonalChatHistory(PersonalChatHistory input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelChatMessageResponse>? AdminChatHistory(AdminChatHistory input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelChatMessageResponse>? GetPersonalChatHistoryV1Public(GetPersonalChatHistoryV1Public input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}